using System;
using System.Linq;

namespace Lesson2
{
    public class Task2: TaskInterface
    {
        private View View { get; }
        public Task2(View view)
        {
            View = view;
        }
        
        public void Execute()
        {
            Console.Clear();
            
            Console.WriteLine("Задача 2: Подсчёт количества цифр в числе\n");
            
            decimal num = View.GetDecimal("Введите число");
            
            Console.WriteLine($"Количество цифр в числе: { NumsCount(num) }");
        }
        
        static int NumsCount(decimal num)
        {
            return FilterNums(num.ToString()).Length;
        }

        static string FilterNums(string str)
        {
            return string.Concat(str.Where(Char.IsDigit));
        }
    }
}