using System;

namespace Lesson2.Task3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int sum = 0;
            int num;
            
            Console.WriteLine("Введите числа (0 - завершить ввод)");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && IsOdd(num))
                {
                    sum += num;
                }
            } while (num != 0);
            
            Console.WriteLine($"\nСумма нечётных положительных чисел: {sum}");
        }

        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
    }
}