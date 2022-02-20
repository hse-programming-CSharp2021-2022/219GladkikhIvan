using System;

namespace Task_03
{
    internal delegate double ConvertTemperature(double x);

    class TemperatureConverterImp
    {
        public double CToF(double tC)
            => 9.0 / 5 * tC + 32;

        public double FtoC(double tF)
            => 5.0 / 9 * (tF - 32);
    }

    class StaticTempConverters
    {
        public static double CToK(double tC)
            => tC + 273.15;

        public static double CToRankin(double tC)
            => 9.0 / 5 * CToK(tC);

        public static double CToReaumur(double tC)
            => 4.0 / 5 * tC;
        
        public static double KToC(double tK)
            => tK - 273.15;

        public static double RankinToC(double tR)
            => 5.0 / 9 * (tR - 491.67);

        public static double ReaumurToC(double tR)
            => 5.0 / 4 * tR;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            testValuesC = new double[3];
            testValuesF = new double[3];
            var rnd = new Random();
            for (var i = 0; i < testValuesC.Length; i++)
                testValuesC[i] = rnd.NextDouble() * 100 + 1;
            
            var converter = new TemperatureConverterImp();
            ConvertTemperature convertCToF = converter.CToF;
            ConvertTemperature convertFToC = converter.FtoC;

            for (var i = 0; i < testValuesC.Length; i++)
                testValuesF[i] = convertCToF(testValuesC[i]);
            
            Test(convertCToF, testValuesC, "Convert C to F");
            Test(convertFToC, testValuesF, "Convert F to C");
            
            var dArr = new ConvertTemperature[8];
            dArr[0] = converter.CToF;
            dArr[1] = converter.FtoC;
            dArr[2] = StaticTempConverters.CToK;
            dArr[3] = StaticTempConverters.KToC;
            dArr[4] = StaticTempConverters.CToRankin;
            dArr[5] = StaticTempConverters.RankinToC;
            dArr[6] = StaticTempConverters.CToReaumur;
            dArr[7] = StaticTempConverters.ReaumurToC;

            var names = new string[8];
            names[0] = "Convert C to F";
            names[1] = "Convert F to C";
            names[2] = "Convert C to K";
            names[3] = "Convert K to C";
            names[4] = "Convert C to Rankin";
            names[5] = "Convert Rankin to C";
            names[6] = "Convert C to Reaumur";
            names[7] = "Convert Reaumur to C";
            
            for (var i = 0; i < 8; i++)
                Test(dArr[i], testValuesC, names[i]);
        }
        
        private static double[] testValuesC;
        private static double[] testValuesF;
        
        public static void Test(ConvertTemperature c, double[] testValues, string name)
        {
            Console.WriteLine($"Testing delegate \"{name}\":");
            foreach (var value in testValues)
            {
                Console.WriteLine($"Value: {value}; Result: {c(value)}.");
            }
            Console.WriteLine("\n* * * * * * * * * *\n");
        }
    }
}