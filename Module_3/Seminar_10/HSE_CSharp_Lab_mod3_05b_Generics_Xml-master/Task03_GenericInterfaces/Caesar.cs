namespace Task03_GenericInterfaces
{
    public class Caesar : IEncrypted<char, char>
    {
        private readonly int _key;

        public Caesar(int key)
        {
            _key = key;
        }

        public char Encode(char u)
        {
            return (char)((u - 'a' + _key) % ('z' - 'a' + 1) + 'a');
        }

        public char Decode(char t)
        {
            return (char)((t - 'a' + 'z' - 'a' + 1 - _key) % ('z' - 'a' + 1) + 'a');
        }
    }

}