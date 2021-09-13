using System;

do
{
    Console.Write("Бюджет: ");
    string sa = Console.ReadLine();
    Console.Write("Процент: ");
    string sp = Console.ReadLine();

    decimal a;
    int p;

    if (decimal.TryParse(sa, out a) && int.TryParse(sp, out p))
    {
        a = a * p / 100;
        Console.WriteLine($"Сумма, выделенная на компьютерные игры: {a:C2}");
    }
    else
        Console.WriteLine("Oшибка ввода!");
    Console.WriteLine("Для выхода нажмите ESC. Для продолжения - любую другую клавишу.");
} while (Console.ReadKey().Key != ConsoleKey.Escape);

