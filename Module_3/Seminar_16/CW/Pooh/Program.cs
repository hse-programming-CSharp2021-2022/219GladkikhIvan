using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingAndSynchronizationTask
{
    internal class BadSolution
    {
        static void Main(string[] args)
        {
            // Неправильная версия программы.
            // Ее можно запустить, она должна поработать какое-то время и сломаться.
            // Как именно она сломается, зависит от компьютера.

            // Ошибки:

            // 1. Не синхронизированы действия пчел.
            // Из этого вытекает:
            // 1) потеря одного наполнения горшка, если две пчелы сделали это действие одновременно;
            // 2) возможное переполнение горшка и последующее бесконечное его наполнение;
            // 3) несколько пчел могут начать будить медведя, а нужно, чтобы это сделала только последняя;

            // 2. Deadlock - пока медведь опустошал горшок, пчелы еще раз принесли мед и разбудили медведя. 
            // В итоге пчелы ждут, пока медведь опустошит горшок, медведь ждет, пока пчелы его разбудят.
            // Проверка ошибки: большое количество пчел + у пчел нет задержки + большая задержка медведя.

            // 3. Использование активного ожидания типа while (pot.IsFull()) { Thread.Sleep(1); } - плохая идея.
            // Заменяется на Monitor.Wait или ManualResetEntry.WaitOne.

            // 4. Последняя пчела при побудке медведя всегда ждет полного выполнения его метода (Task.Run(() => bear.WakeUp()).Wait();).
            // Это не критично, но нехорошо. 

            // 5. В методе Main запускается Task.Run(() => createdBee.IncrementPotFullness());
            // Но createdBee передается в задачу как ссылка на объект, а значит, все задачи будут запущены от одной и той же пчелы.
            // Проверяется добавлением каждой пчеле имени i и последующим выводом имени пчелы при наполнении горшка.

            // Программа должна работать в любых случаях,
            // 1. И со включенным долгим Thread.Sleep() у медведя;
            // 2. И вообще без Thread.Sleep();

            int numberOfBees = 200;
            Pot pot = new Pot(50);
            Bear bear = new Bear(pot);
            HashSet<Bee> bees = new HashSet<Bee>();
            
            for (int i = 0; i < numberOfBees; i++)
            {
                var createdBee = new Bee(pot, bear);
                bees.Add(createdBee);
                Task.Run(() => createdBee.IncrementPotFullness());
            }

            // Дополнительно:
            // 1. Использовать Interlocked.Increment() внутри Pot.
            // 2. Использовать ManualResetEventSlim вместо Monitor.
            // 3.1. Запустить всех пчел разом, используя Barrier или ManualResetEventSlim.
            // 3.2. Посмотреть, в чем разница, если запускать всех пчел через Task и если через Thread (В Отладка->Окна->Потоки/Задачи).

            Console.ReadLine();
        }
    }

    class Pot
    {
        private int capacity;
        private int fullness;

        public Pot(int capacity)
        {
            this.capacity = capacity;
        }

        public void IncrementFullness()
        {
            fullness++;
            Console.WriteLine(fullness);
        }

        public bool IsFull()
        {
            return fullness == capacity;
        }

        public void MakeEmpty()
        {
            fullness = 0;
        }
    }

    class Bee
    {
        private Pot pot;
        private Bear bear;

        public Bee(Pot pot, Bear bear)
        {
            this.pot = pot;
            this.bear = bear;
        }

        public void IncrementPotFullness()
        {
            while (true)
            {
                Thread.Sleep(200);
                while (pot.IsFull())
                {
                    Thread.Sleep(1);
                }
                pot.IncrementFullness();
                if (pot.IsFull())
                {
                    Console.WriteLine("Wake up the bear!");
                    Task.Run(() => bear.WakeUp()).Wait();
                }
            }
        }
    }

    class Bear
    {
        private Pot pot;
        private bool isSleeping = true;
        public static Mutex mutex = new Mutex();

        public Bear(Pot pot)
        {
            this.pot = pot;
        }

        public void WakeUp()
        {
            if (isSleeping)
            {
                mutex.WaitOne();
                isSleeping = false;
                pot.MakeEmpty();
                Thread.Sleep(1000);
                isSleeping = true;
                mutex.ReleaseMutex();   
            }
        }
    }
}