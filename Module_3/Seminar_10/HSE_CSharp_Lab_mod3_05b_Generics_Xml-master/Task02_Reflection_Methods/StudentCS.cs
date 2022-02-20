using System;
using System.Dynamic;
using System.Reflection;

namespace Task02_Reflection_Methods
{
    public class StudentCS: Student
    {
        public StudentCS(string name) : base(name)
        {
        }

        public void ReportMethodCheck(string methodName)
        {
            Type? t = ExistMethod(methodName);
            if (t == null)
            {
                Console.WriteLine($"Студент {Name} не обнаружил метод {methodName}");
            }
            else
            {
                Console.WriteLine($"Студент {Name} обнаружил метод {methodName} в {t.Name}");
            }
        }

        private Type? ExistMethod(string code)
        {
            // AppDomain.CurrentDomain.GetAssemblies()
            Assembly a = Assembly.GetExecutingAssembly();
            // Console.WriteLine("\tAssembly: " + a.FullName);
            foreach (Type type in a.GetTypes())
            {
                // TODO
            }
            throw new NotImplementedException();
        }
    }
}