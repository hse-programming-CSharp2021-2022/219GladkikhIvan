using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XmlDocument
{
    class Program
    {
        static void Main(
            string[] args)
        {
            var xDoc = new System.Xml.XmlDocument();
            try
            {
                xDoc.Load("../../../data/users/user.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка чтения файла:{e.Message}");
            }


            var documentElement = xDoc.DocumentElement;
            if (documentElement is null)
            {
                Console.WriteLine("Ошибка загрузки файла 'user.xml'.");
                return;
            }

            var userInfos = new List<User>();
            // Обход элементов списка
            foreach (XmlElement userNode in documentElement.ChildNodes)
            {
                var user = ParseUser(userNode);
                userInfos.Add(user);
            }

            var groupedUsers = userInfos
                .GroupBy(x => x.Country)
                .Select(x =>
                    new
                    {
                        countryName = x.Key,
                        users = x.Select(user => user).ToList()
                    })
                .ToList();

            foreach (var group in groupedUsers)
            {
                SaveCountryUsers(group.countryName, group.users);
            }
        }

        /// <summary>
        /// Возвращаем сущность пользователя, если удачно десереализовали.
        /// Иначе null.
        /// TODO Можно переделать на проброс исключений.
        /// TODO Но здесь не библиотечный подход, а с точки зрения производительности без них быстрее.
        /// </summary>
        private static User ParseUser(
            XmlNode userNode)
        {
            if (userNode.Attributes is null)
            {
                Console.WriteLine($"Ошибка обработки ноды: {userNode.OuterXml}");
                return null;
            }

            var nameAttribute = userNode.Attributes.GetNamedItem("name");
            var userName = nameAttribute is not null ? nameAttribute.Value : "unknown";

            long userId = default, userAge = default;
            string userCountry = string.Empty;
            foreach (XmlNode childNode in userNode.ChildNodes)
            {
                switch (childNode.Name)
                {
                    case "id" when !long.TryParse(childNode.InnerText, out userId):
                        return null;
                    case "country":
                        userCountry = childNode.InnerText;
                        break;
                    case "age" when !long.TryParse(childNode.InnerText, out userAge):
                        return null;
                }
            }

            return new User(userId, userName, userCountry, userAge);
        }

        /// <summary>
        /// Записываем группу по стране в соотвествующий файл
        /// %country_name%_users.xml;
        /// </summary>
        private static void SaveCountryUsers(
            string countryName,
            IReadOnlyList<User> users)
        {
            var newXmlDocument = new System.Xml.XmlDocument();
            var xmlDeclaration = newXmlDocument.CreateXmlDeclaration( "1.0", "UTF-8", null );
            var rootElement = newXmlDocument.DocumentElement;
            newXmlDocument.InsertBefore( xmlDeclaration, rootElement );

            var usersList = newXmlDocument.CreateElement( string.Empty, "users", string.Empty );
            newXmlDocument.AppendChild(usersList);

            foreach (var user in users)
            {
                // Создали элемент пользователя
                var userElement = newXmlDocument.CreateElement( string.Empty, "userId", string.Empty );

                // Создали аттрибут
                var userNameAttribute = newXmlDocument.CreateAttribute("name");
                // Создали значение аттрибута
                var userNameText = newXmlDocument.CreateTextNode(user.Name);
                // Добавили в документ
                userNameAttribute.AppendChild(userNameText);
                userElement.Attributes.Append(userNameAttribute);

                // Создали ноду
                var userIdText = newXmlDocument.CreateTextNode(user.Id.ToString());
                // Добавили в документ
                userElement.AppendChild(userIdText);
                usersList.AppendChild(userElement);

                // Добавили юзера в список
                usersList.AppendChild(userElement);
            }
            try
            {
                newXmlDocument.Save($"../../../data/countries/{countryName}_users.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка сохранения файла:{e.Message}");
            }
        }
    }
}
