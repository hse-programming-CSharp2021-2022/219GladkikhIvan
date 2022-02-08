using System;

namespace Theory
{
    class A
    {
        public int MyMethodA(int a)
        {
            Console.WriteLine(1);
            return 2;
        }
    }
    
    class Program
    {
        public static int MyMethod(int a)
        {
            Console.WriteLine(1);
            return 1;
        }

        public int MyMethodNonStatic(int a)
        {
            Console.WriteLine(1);
            return 3;
        }
        
        public delegate int MyDel(int a);
        
        static void Main(string[] args)
        {
            var myDel = new MyDel(MyMethod);
            var a = new A();
            MyDel myDel2 = a.MyMethodA;
            MyDel myDel3 = new Program().MyMethodNonStatic;
            MyDel myDel4 = delegate (int a)
            {
                Console.WriteLine(2);
                return 4;
            };
            MyDel myDel5 = (int a) =>
            {
                Console.WriteLine(2);
                return 5;
            };

            myDel(1); 
            myDel2(2);
            myDel4(4); 
            myDel5(5); 
            
            Console.WriteLine(myDel.Method); 
            Console.WriteLine(myDel.Target); 
            
            Console.WriteLine(myDel2.Method); 
            Console.WriteLine(myDel2.Target); 
            
            Console.WriteLine(myDel4.Method); 
            Console.WriteLine(myDel4.Target); 
            
            Console.WriteLine(myDel5.Method); 
            Console.WriteLine(myDel5.Target); 

            var myDel6 = myDel + myDel2 + myDel3 + myDel4 + myDel5;
            Console.WriteLine(myDel6(6));
            myDel6 += myDel2;
            Console.WriteLine(myDel6.Method); =
            Console.WriteLine(myDel6.Target); 
            myDel6 -= myDel2;
        }
    }
}