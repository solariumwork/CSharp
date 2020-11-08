using System;
using System.Text;
using Lesson2.Auth;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();

            ConsoleKey key;
            do
            {
                Console.WriteLine("Введите номер задачи от 1 до 7, 0 - закончить");
                switch (key = Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        ExecuteTask(new Task1(view));
                        break;
                    case ConsoleKey.D2:
                        ExecuteTask(new Task2(view));
                        break;
                    case ConsoleKey.D3:
                        ExecuteTask(new Task3(view));
                        break;
                    case ConsoleKey.D4:
                        ExecuteTask(new Task4(view, new AuthService()));
                        break;
                    case ConsoleKey.D5:
                        ExecuteTask(new Task5(view, new WeightCalculator()));
                        break;
                    case ConsoleKey.D6:
                        ExecuteTask(new Task6());
                        break;
                    case ConsoleKey.D7:
                        ExecuteTask(new Task7(view));
                        break;
                }
            } while (key != ConsoleKey.D0);
        }

        static void ExecuteTask(ITask task)
        {
            Console.Clear();
            task.Execute();
        }
    }
}