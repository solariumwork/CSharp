using System;
using ViewModule;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            IView view = new ConsoleView();

            ConsoleKey key;
            do
            {
                switch (key = view.GetKey("Введите номер задачи от 1 до 4, 0 - закончить"))
                {
                    case ConsoleKey.D1:
                        ExecuteTask(new Task1(view, new Random()));
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