using System.Collections;
using System.Collections.Generic;

namespace Task_03
{
    public class TriangleNums
    {
        public IEnumerable<int> GetNums(int n)
        {
            for (var i = 0; i < n; i++)
                yield return i * (i + 1) / 2;
        }
    }
}