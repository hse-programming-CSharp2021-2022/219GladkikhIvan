using System;
using System.Collections;

namespace Task_03
{
    class Fibonacci : IEnumerable
    {
        private int a0 = 1;
        private int a1 = 1;


        public IEnumerable NextElemet(int n)
        {
            for (var i = 0; i < n; i++)
            {
                yield return a0;
                var a = a0 + a1;
                a0 = a1;
                a1 = a;
            }
        }

        public IEnumerator GetEnumerator()
            => new FibEnumerator(10);

        class FibEnumerator : IEnumerator
        {
            public bool MoveNext()
            {
                (f0, f1) = (f1, f0 + f1);
                pos++;
                return pos < border;
            }

            public void Reset()
                => (f0, f1, pos) = (0, 1, 0);

            private int f0 = 0;
            private int f1 = 1;
            private int border;
            private int pos = 0;
            public object Current => f0;

            public FibEnumerator(int border)
                => this.border = border;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fibonacci();
            foreach (var el in f.NextElemet(10))
            {
                Console.WriteLine(el);
            }

            foreach (var el in f)
            {
                Console.WriteLine(el);
            }
        }
    }
}