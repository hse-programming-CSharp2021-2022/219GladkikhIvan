using System;
using System.IO;

namespace Task_EXCEPTIONS
{
    class MyException : Exception
    {
        public MyException() { }
        
        public MyException(string message)
            : base(message) { }
    } 
    
    class Program
    {
        static void Main(string[] args)
        {
            // DivideByZeroException
            try
            {
                int x = 0;
                var y = 1 / x;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            // NullReferenceException
            try
            {
                string s = null;
                Console.WriteLine(s[0]);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            // IndexOutOfRangeException
            try
            {
                var m = new int[3];
                Console.WriteLine(m[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            // IOException
            try
            {
                var sw1 = new StreamWriter("txt.txt");
                var sw2 = new StreamWriter("txt.txt");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
            // OverflowException
            try
            {
                int x = 780000000;
                checked
                {
                    int y = x * x;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);    
            }

            // InvalidCastException
            try
            {
                object x = "you";
                int y = (int) x;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            // FormatException
            try
            {
                var s = "abc";
                var x = int.Parse(s);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
            // FileNotFoundException
            try
            {
                var sr = new StreamReader("gg.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                throw new MyException("My exception");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
