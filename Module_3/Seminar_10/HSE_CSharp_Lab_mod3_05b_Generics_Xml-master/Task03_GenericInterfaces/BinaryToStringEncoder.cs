using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03_GenericInterfaces
{
    public abstract class BinaryToStringEncoder : IEncrypted<byte[], string>
    {
        protected abstract Dictionary<string, byte[]> GetDictionary();

        public byte[] Encode(string u)
        {
            var dict = GetDictionary();
            return dict.GetValueOrDefault(u);
        }

        public string Decode(byte[] t)
        {
            var dict = GetDictionary();
            bool flag = false;
            string s = "";
            foreach (var el in dict)
            {
                flag = true;
                s = el.Key;
                for (int i = 0; i < el.Value.Length; i++)
                {
                    if (el.Value.Length != t[i])
                        flag = false;

                }

                if (!flag)
                    break;
            }
            return s;
        }
    }

}