using System;
/*
    •В библиотеке классов описать:
    – делегат ConvertRule, представляющий методы, возвращающие строку, с одним параметром – строкой
    –Класс Converter с нестатическим методом public string Convert(string str, ConvertRule cr). Метод преобразует строку str по правилу cr.
    •В проекте консольного приложения описать два метода преобразования строк:
    –public static string RemoveDigits(string str) – возвращает строку, полученную из str удалением цифр
    – public static string RemoveSpaces(string str) – возвращает строку, полученную из str удалением пробелов
    –В методе Main() описать массив тестовых строк, связать методы с объектом-делегатом типа ConvertRule и протестировать работу каждого метода.
    –Связать один многоадресный делегат с обоими методами и протестировать вызовы на том же массиве строк.
    –Добиться последовательного применения обоих преобразований к элементам массива на многоадресном делегате (использовать GetInvocationList).
*/

namespace Task_03
{
    class Program
    {
        delegate string ConvertRule(string n);

        public static string RemoveDigits(string str)
        {
            string s = String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    s += str[i];
                }
            }
            return s;
        }
        
        public static string RemoveSpaces(string str)
        {
            return str.Replace(" ", "");
        }
        
        static void Main(string[] args)
        {
            string[] n = {"dfg32", "ssd21", "g q12 2"};
            ConvertRule t = RemoveDigits;
            t = t + RemoveSpaces;
            for (int i = 0; i < n.Length; i++)
            {
                foreach (ConvertRule num in t.GetInvocationList())
                {
                    Console.WriteLine(num(n[i]));
                }
            }
        }
    }
}