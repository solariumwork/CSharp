using System;
using Lesson4.Auth;
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
                switch (key = view.GetKey("Введите номер задачи 1 или 3, 0 - закончить"))
                {
                    case ConsoleKey.D1:
                        ExecuteTask(new Task1(view, new Random()));
                        break;
                    case ConsoleKey.D3:
                        ExecuteTask(new Task3(view, new AuthService()));
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