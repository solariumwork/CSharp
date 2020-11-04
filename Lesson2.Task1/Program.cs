namespace Lesson2.Task1
{
    using System;

    class Program
    {
        static float Min(float a, float b, float c)
        {
            return Min(Min(a, b), c);
        }

        static float Min(float a, float b)
        {
            if (a < b)
            {
                return a;
            }

            return b;
        }
        
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            float a = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("\nВведите второе число");
            float b = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("\nВведите третье число");
            float c = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine($"\nМинимальное число: { Min(a, b, c) }");
        }
    }
}
