using System;

namespace Task_03
{
    class Polygon
    {
        public int N { get; set; }
        public double R { get; set; }
        
        public double Perimeter { get; }
        public double Area { get; }

        public Polygon(int n = 1, double r = 0)
        {
            N = n;
            R = r;
            double a = 2 * R * Math.Tan(Math.PI / N);
            Perimeter = N * a;
            Area = 0.5 * a * N * R;
        }

        public string PolygonData()
            => $"N = {N}, r = {R}, P = {Perimeter}, S = {Area}";
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Polygon[] m;
            m = new Polygon[0];
            var nom = -1;
            // Заполняем массив.
            while (true)
            {
                nom++;
                
                Array.Resize(ref m, nom + 1);
                Console.WriteLine("\nВведите параметры многоугольника №{0}", nom + 1);
                
                Console.Write("Кол-во сторон: ");
                var n = int.Parse(Console.ReadLine());
                
                Console.Write("Радиус вписанной окружности: ");
                var r = double.Parse(Console.ReadLine());

                if (n == 0 && r == 0)
                    break;

                m[nom] = new Polygon(n, r);
            }
            var k = nom;
            
            // Находим номера многоугольников с минимальной и максимальной площадями.
            double maxS = m[0].Area, minS = m[0].Area;
            int maxI = 0, minI = 0;
            for (var i = 1; i < k; i++)
            {
                if (m[i].Area > maxS) maxI = i;
                if (m[i].Area < minS) minI = i;
            }
            
            // Выводим информацию о многоугольниках.
            for (var i = 0; i < k; i++)
            {
                if (i == minI) 
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (i == maxI)
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"№{i+1}: {m[i].PolygonData()}.");
                Console.ResetColor();
            }
        }
    }
}