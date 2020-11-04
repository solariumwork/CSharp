using System;

namespace Lesson2.Task2
{
    static class Program
    {
        static int NumsCount(float num)
        {
            string numString = num.ToString();
            if (numString.Contains(","))
            {
                return numString.Length - 1;
            }

            return numString.Length;
        }
        
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            float num = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Количество цифр в числе: { NumsCount(num) }");
        }
    }
}