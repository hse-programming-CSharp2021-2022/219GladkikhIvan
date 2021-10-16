using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task_01 {
    class Program {
        static void Main(string[] args) {
            string path = @"Data.txt";

            File.Create(path);
            // Создаем файл с данными
            if (File.Exists(path)) {
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                var createText = new StringBuilder();
                var rnd = new Random();
                var k = int.Parse(Console.ReadLine());
                for (var i = 0; i < k; i++)
                {
                    for (var j = 0; j < 5; j++)
                        createText.Append(rnd.Next(10, 100) + " ");
                    createText.Append(Environment.NewLine);
                }
                File.WriteAllText(path, createText.ToString(), Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path)) {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                foreach(int i in arr) {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                var evenList = new List<int>();
                var oddList = new List<int>();
                for (var i = 0; i< arr.Length; i++)
                    if (arr[i] % 2 == 0)
                        oddList.Add(i);
                    else
                        evenList.Add(i);
                var even = evenList.ToArray();
                Array.ForEach(even, i => Console.Write(i + " "));
                Console.WriteLine();
                var odd = oddList.ToArray();
                Array.ForEach(odd, i => Console.Write(i + " "));
                Console.WriteLine();

                // TODO3: Заменяем все нечётные числа исходного массива нулями
                for (var i = 0; i < even.Length; i++)
                    arr[even[i]] = 0;
                Array.ForEach(arr, i => Console.Write(i + " "));
            }
        } // end of Main()
        
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str) {
            int[] arr = null;
            if (str.Length != 0) {
                arr = new int[0];
                foreach (string s in str) {
                    int tmp;
                    if (int.TryParse(s, out tmp)) {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}