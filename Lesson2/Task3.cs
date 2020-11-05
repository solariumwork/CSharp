using System;

namespace Lesson2
{
    public class Task3
    {
        private View View { get; }
        public Task3(View view)
        {
            View = view;
        }
        
        public void Execute()
        {
            Console.Clear();
            
            Console.WriteLine("Задача 3: Подсчёт cуммы нечётных положительных чисел\n");
            
            int sum = 0;
            int num;
            
            Console.WriteLine("Введите числа (0 - завершить ввод)");
            do
            {
                num = View.GetInt();
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