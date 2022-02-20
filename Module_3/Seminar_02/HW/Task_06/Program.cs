using System;

namespace Task_06
{
    class Plant
    {
        private int growth, photosensitivity, frostresistance;

        public int Growth => growth;
        public int Photosensitivity => photosensitivity;
        public int Frostresistance => frostresistance;

        public Plant(int g, int p, int f)
            => (growth, photosensitivity, frostresistance) = (g, p, f);

        public override string ToString()
            => $"Plant | Growth : {growth}; Photosensitivity : {photosensitivity}; Frostresistance : {frostresistance}";

        public static Plant GeneratePlant()
        {
            var rnd = new Random();
            
            var g = rnd.Next(25, 101);
            var p = rnd.Next(101);
            var f = rnd.Next(81);

            return new Plant(g, p, f);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type \'n\': ");
            var n = int.Parse(Console.ReadLine());
            
            var plants = new Plant[n];
            for (var i = 0; i < n; i++)
                plants[i] = Plant.GeneratePlant();
            
            Console.WriteLine("\n* * * * * * * * * *\n");
            
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine("\n* * * * * * * * * *\n");
            
            Array.Sort(plants, delegate (Plant plant1, Plant plant2) 
            {
                if (plant1.Growth < plant2.Growth)
                    return 1;
                if (plant1.Growth > plant2.Growth)
                    return -1;
                return 0;
            });
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine("\n* * * * * * * * * *\n");
            
            Array.Sort(plants, (plant1, plant2) =>
            {
                if (plant1.Frostresistance > plant2.Frostresistance)
                    return 1;
                if (plant1.Frostresistance < plant2.Frostresistance)
                    return -1;
                return 0;
            });
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine("\n* * * * * * * * * *\n");
            
            Array.Sort(plants, PhotosensitivityComparer);
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine("\n* * * * * * * * * *\n");

            plants = Array.ConvertAll(plants, plant =>
            {
                var newFrostresistance = plant.Frostresistance % 2 == 0
                    ? plant.Frostresistance / 3
                    : plant.Frostresistance / 2;
                return new Plant(plant.Growth, plant.Photosensitivity, newFrostresistance);
            });
            Array.ForEach(plants, Console.WriteLine);
        }

        public static int PhotosensitivityComparer(Plant p1, Plant p2)
        {
            if (p1.Photosensitivity % 2 == 0 && p2.Photosensitivity % 2 != 0)
                return 1;
            if (p1.Photosensitivity % 2 != 0 && p2.Photosensitivity % 2 == 0)
                return -1;
            return 0;
        }
    }
}