using System.Collections.Generic;

namespace Task03_GenericInterfaces
{
    // алгоритм равномерного кодирования 8-ми направлений ветра: 
    // С, Ю, З, В, СЗ, СВ, ЮЗ, ЮВ.
    public class WindEncoder : BinaryToStringEncoder
    {
        protected override Dictionary<string, byte[]> GetDictionary()
        {
            return new Dictionary<string, byte[]>
            {
                { "С", new byte[] { 0, 0, 0 } },
                { "Ю", new byte[] { 1, 0, 0 } },
                { "З", new byte[] { 1, 1, 0 } },
                { "В", new byte[] { 0, 1, 0 } },
                { "СЗ", new byte[] { 1, 1, 1 } },
                { "СВ", new byte[] { 0, 0, 1 } },
                { "ЮЗ", new byte[] { 1, 0, 1 } },
                { "ЮВ", new byte[] { 0, 1, 1 } }
            };
        }
    }

}