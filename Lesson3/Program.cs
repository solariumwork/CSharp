using System;
using ViewModule;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            IView view = new ConsoleView();

            ConsoleKey key;
            do
            {
                switch (key = view.GetKey("Введите номер задачи от 1 до 3, 0 - закончить"))
                {
                    case ConsoleKey.D1:
                        ExecuteTask(new Task1(view));
                        break;
                    case ConsoleKey.D2:
                        ExecuteTask(new Task2(view));
                        break;
                    case ConsoleKey.D3:
                        ExecuteTask(new Task3(view, new FractionFactory()));
                        break;
                }
            } while (key != ConsoleKey.D0);
        }

        static void ExecuteTask(ITask task)
        {
            Console.Clear();
            try
            {
                task.Execute();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"\n{exception.Message}");
            }
        }
    }
}