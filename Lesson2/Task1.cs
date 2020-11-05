using System;

namespace Lesson2
{
    public class Task1
    {
        private View View { get; }
        public Task1(View view)
        {
            View = view;
        }
        public void Execute()
        {
            Console.Clear();
            
            Console.WriteLine("Задача 1: Поиск минимального числа из 3 чисел\n");
            
            float a = View.GetFloat("Введите первое число");
            float b = View.GetFloat("\nВведите второе число");
            float c = View.GetFloat("\nВведите третье число");

            Console.WriteLine($"\nМинимальное число: { Min(a, b, c) }");
        }
        
        private static float Min(float a, float b, float c)
        {
            return Min(Min(a, b), c);
        }

        private static float Min(float a, float b)
        {
            return (a < b) ? a : b;
        }
    }
}