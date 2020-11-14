using System;

namespace Lesson2
{
    public class Task7: ITask
    {
        private View View { get; }

        public Task7(View view)
        {
            View = view;
        }
        
        public void Execute()
        {
            Console.WriteLine("Задача 7: Рекурсивно вывысти числа от a до b (a < b)");
            Console.WriteLine("(б) Рекурсивно вывести сумму чисел от a до b (a < b)");

            int a;
            int b;
            do
            {
                a = View.GetInt("Введите a");
                b = View.GetInt("Введите b");
            } while (a > b);

            Console.WriteLine($"Числа от {a} до {b}");
            ShowNums(a, b);
            
            Console.WriteLine($"Сумма чисел от {a} до {b}");
            ShowNumsSum(a, b);
        }

        private void ShowNums(int from, int to)
        {
            Console.WriteLine($"{from}");
            
            if (from < to)
            {
                from++;
                ShowNums(from, to);
            }
        }

        private void ShowNumsSum(int from, int to, int sum = 0)
        {
            sum += from;
            
            if (from < to)
            {
                from++;
                ShowNumsSum(from, to, sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}