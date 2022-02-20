using System.Collections.Generic;

namespace Task03_GenericInterfaces
{
    // алгоритм равномерного кодирования 4-х сторон света: 
    // С, Ю, З, В.
    public class SideOfTheWorldEncoder : BinaryToStringEncoder
    {
        protected override Dictionary<string, byte[]> GetDictionary()
        {
            return new Dictionary<string, byte[]>
            {
                { "С", new byte[] { 0, 0 } },
                { "Ю", new byte[] { 1, 0 } },
                { "З", new byte[] { 1, 1 } },
                { "В", new byte[] { 0, 1 } }
            };
        }
    }

}