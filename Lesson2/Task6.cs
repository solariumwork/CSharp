using System;

namespace Lesson2
{
    public class Task6 : ITask
    {
        private int SumDigit(int num)
        {
            int sum = 0;
            do
            {
                sum += num % 10;
                num /= 10;
            } while (num > 0);

            return sum;
        }

        public void Execute()
        {
            Console.WriteLine("Задача 6: Посчитать количество хороших символов. Посчитать время исполнения программы");

            Timer timer = new Timer();
            timer.Start();
            
            int goodNumsCount = 0;
            for (int i = 1; i < 1000000; i++)
            {
                if (i % SumDigit(i) == 0)
                {
                    goodNumsCount++;
                }
            }

            Console.WriteLine($"Количество хороших чисел: {goodNumsCount}");

            TimeSpan executeTime = timer.Stop();
            Console.WriteLine($"Время исполнения программы: \nсекунд: {executeTime.Seconds} \nмиллисекунд: {executeTime.Milliseconds}");
        }
    }
}