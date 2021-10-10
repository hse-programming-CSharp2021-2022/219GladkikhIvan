using System;

namespace Task_01
{
    class Program
    {
        public static int[] Zip(int[] m)
        {
            int k = m.Length;
            int sum, p;
            int i = 0;
            while (i < k - 1)
            {
                sum = m[i] + m[i + 1];
                if (sum % 3 == 0)
                {
                    p = m[i] * m[i + 1];
                    m[i] = p;
                    for (int j = i + 1; j < k - 1; j++)
                        m[j] = m[j + 1];
                    k--;
                }

                i++;
            }

            if (i == k - 1)
            {
                m[i] = 0;
                k--;
            }

            int[] nm = new int[k];
            for (int j = 0; j < k; j++)
                nm[j] = m[j];
            return nm;
        }

        static void Main(string[] args)
        {
            int[] m = { 1, 2, 3, 4, 5, 6 };
            int[] nm = Zip(m);
            foreach (int a in nm)
                Console.Write($"{a} ");
        }
    }
}