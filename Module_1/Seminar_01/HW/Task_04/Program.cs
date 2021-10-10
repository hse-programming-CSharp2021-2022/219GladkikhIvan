using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение напряжения U: ");
            string sU = Console.ReadLine();
            Console.Write("Введите значение сопротивления R: ");
            string sR = Console.ReadLine();
            int U;
            int R;
            if ((int.TryParse(sU, out U)) & (int.TryParse(sR, out R)))
            {
                Console.WriteLine("Сила тока I = U / R = " + U / R);
                Console.WriteLine("Потребляемая мощность P = U^2 / R = " + U * U / R);
            }
            else
                Console.WriteLine("Неверный формат ввода!");

            Console.ReadLine();
        } 
    } 
} 