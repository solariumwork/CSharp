using System;
using Lesson2.Auth;

namespace Lesson2
{
    class Program
    {
        private const string TO_NEXT_TASK_MESSAGE = "\nEnter - переход к следующей задаче\nДругая клавиша - повторить задачу\n";
        
        static void Main(string[] args)
        {
            View view = new View();

            ExecuteTask(new Task1(view));
            ExecuteTask(new Task2(view));
            ExecuteTask(new Task3(view));
            ExecuteTask(new Task4(view, new AuthService()), true);
        }

        static void ExecuteTask(ITask task, bool isLastTask = false)
        {
            if (isLastTask)
            {
                task.Execute();
                return;
            }
            
            do
            {
                task.Execute();
                Console.WriteLine(TO_NEXT_TASK_MESSAGE);
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }
}