using System.Linq;

namespace Lesson2.Task2
{
    using System;
    
    static class Program
    {
        static int NumsCount(decimal num)
        {
            return FilterNums(num.ToString()).Length;
        }

        static string FilterNums(string str)
        {
            return string.Concat(str.Where(Char.IsDigit));
        }
        
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            decimal num = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Количество цифр в числе: { NumsCount(num) }");
        }
    }
}