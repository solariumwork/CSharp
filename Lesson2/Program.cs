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

            Task1 task1 = new Task1(view);
            do
            {
                task1.Execute();
            } while (view.GetKey(TO_NEXT_TASK_MESSAGE) != ConsoleKey.Enter);

            Task2 task2 = new Task2(view);
            do
            {
                task2.Execute();
            } while (view.GetKey(TO_NEXT_TASK_MESSAGE) != ConsoleKey.Enter);

            Task3 task3 = new Task3(view);
            do
            {
                task3.Execute();
            } while (view.GetKey(TO_NEXT_TASK_MESSAGE) != ConsoleKey.Enter);
            
            Task4 task4 = new Task4(view, new AuthService());
            task4.Execute();
        }
    }
}