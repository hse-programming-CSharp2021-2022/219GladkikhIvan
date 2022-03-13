using System.Collections.Generic;

namespace Task_03
{
    public class Fibonacci
    {
        public IEnumerable<int> GetNums(int n)
        {
            var f0 = 0;
            var f1 = 1;
            for (var i = 0; i < n; i++)
            {
                (f0, f1) = (f1, f0 + f1);
                yield return f0;
            }
        }
    }
}