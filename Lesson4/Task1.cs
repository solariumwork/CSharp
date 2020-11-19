using System;
using ViewModule;

namespace Lesson4
{
    public class Task1: ITask
    {
        private readonly IView _view;
        private readonly Random _random;
        
        public Task1(IView view, Random random)
        {
            _view = view;
            _random = random;
        }

        public void Execute()
        {
            _view.PrintLine("Задача 1: Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.");
            _view.PrintLine("Вывести количество пар элементов массива, в которых хотя бы одно число делится на 3");
            _view.PrintLine("В данной задаче под парой подразумевается два подряд идущих элемента массива.");
            _view.PrintLine("Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.\n");

            _view.PrintLine("Было введено 20 рандомных чисел");
            _view.Print("Числа: ");
            int [] nums = new int[20];
            for (var i = 0; i < 20; i++)
            {
                nums[i] = _random.Next(-10000, 10000);
                _view.Print($"{nums[i]} ");
            }

            int pairsDivisibleBy3 = 0;
            bool isPrevNumDivisibleBy3 = HasDigitDivisibleBy3(nums[0]);
            bool iSCurrentNumDivisibleBy3;
            for (var i = 1; i < 20; i++)
            {
                iSCurrentNumDivisibleBy3 = HasDigitDivisibleBy3(nums[i]);
                if (isPrevNumDivisibleBy3 || iSCurrentNumDivisibleBy3)
                {
                    pairsDivisibleBy3++;
                }
                
                isPrevNumDivisibleBy3 = iSCurrentNumDivisibleBy3;
            }
            
            _view.PrintLine($"\nКоличество пар, делящихся на 3: {pairsDivisibleBy3}\n");
        }

        private bool HasDigitDivisibleBy3(int num)
        {
            string numString = num.ToString();
            
            for (var i = 0; i < numString.Length; i++)
            {
                if (Char.GetNumericValue(numString[i]) % 3 == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}