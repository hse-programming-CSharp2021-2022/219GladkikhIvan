using System;

namespace Task02_Reflection_Methods
{
    public class StudentEconomic: Student
    {
        public StudentEconomic(string name) : base(name)
        {
        }

        static Random rnd = new Random();
        public void PredictBitcoin()
        {
            if (rnd.Next(1) == 0)
            {
                Console.WriteLine($"Студент {Name} считает, что биткоин вырастет");
            }
            else
            {
                Console.WriteLine($"Студент {Name} считает, что биткоин упадет");
            }
        }

    }
}