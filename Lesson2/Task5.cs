using System;

namespace Lesson2
{
    public class Task5: ITask
    {
        private View View { get; }

        private WeightCalculator WeightCalculator { get; }

        public Task5(View view, WeightCalculator weightCalculator)
        {
            View = view;
            WeightCalculator = weightCalculator;
        }
        
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Задача 5: Вычислить индекс массы, рассчитать насколько нужно похудеть или набрать веса\n");
            
            int height = View.GetInt("Введите рост (см)");
            int weight = View.GetInt("\nВведите вес (кг)");
            
            double bodyMassIndex = WeightCalculator.CalculateBodyMassIndex(weight, height);
            NormalWeight normalWeight = WeightCalculator.CalculateNormalWeight(height);
            
            Console.WriteLine($"Ваш индекс массы тела: {bodyMassIndex:F2}\n");
            if (weight < normalWeight.Min)
            {
                Console.WriteLine($"Вам нужно набрать {normalWeight.Min - weight} кг");
                return;
            }

            if (weight > normalWeight.Max)
            {
                Console.WriteLine($"Вам нужно сбросить {weight - normalWeight.Max} кг");
                return;
            }
            
            Console.WriteLine("Ваш вес в норме");
        }
    }
}