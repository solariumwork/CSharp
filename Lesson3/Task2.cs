using System;
using System.Collections.Generic;

namespace Lesson3
{
    public class Task2: ITask
    {
        private readonly IView _view;
        
        public Task2(IView view)
        {
            _view = view;
        }

        public void Execute()
        {
            _view.PrintLine("Задача 2: Вывести введённые числа и cумму нечётных положительных чисел\n");
            
            int sum = 0;
            List<int> nums = new List<int>();
            int num;

            _view.PrintLine("Введите числа (0 - завершить ввод)");
            do
            {
                num = _view.GetInt();
                if (num == 0)
                {
                    continue;
                }
                
                nums.Add(num);
            } while (num != 0);

            _view.PrintLine("Введённые числа");
            for (var i = 0; i < nums.Count; i++)
            {
                num = nums[i];
                if (num > 0 && IsOdd(num))
                {
                    sum += num;
                }
                
                _view.PrintLine(num.ToString());
            }
            
            _view.PrintLine($"\nСумма нечётных положительных чисел: {sum}");
        }
        
        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
    }
}