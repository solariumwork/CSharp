using System;
using ViewModule;

namespace Lesson3
{
    public class Task3: ITask
    {
        private readonly IView _view;
        private readonly FractionFactory _fractionFactory;
        
        public Task3(IView view, FractionFactory fractionFactory)
        {
            _view = view;
            _fractionFactory = fractionFactory;
        }

        public void Execute()
        {
            _view.PrintLine("Задача 3: Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.");
            _view.PrintLine("Продемонстрировать сложение, вычитание, умножение, деление дробей");
            _view.PrintLine("Добавить проверку, что знаменатель != 0");
            _view.PrintLine("Добавить упрощение дробей\n");

            _view.PrintLine("--------------------Ввод первой дроби--------------------");
            Fraction x = _fractionFactory.CreateFromView(_view);
            _view.PrintLine("--------------------Ввод второй дроби--------------------");
            Fraction y = _fractionFactory.CreateFromView(_view);
            if (x == null || y == null)
            {
                throw new Exception("Не удалось ввести дробь");
            }
            
            _view.PrintLine("Сложение дробей");
            _view.PrintLine($"Вы ввели {x} и {y}");
            _view.PrintLine($"Результат сложение: {x + y}\n");
            
            _view.PrintLine("Вычитание дробей");
            _view.PrintLine($"Вы ввели {x} и {y}");
            _view.PrintLine($"Результат вычитания: {x - y}\n");
            
            _view.PrintLine("Умножение дробей");
            _view.PrintLine($"Вы ввели {x} и {y}");
            _view.PrintLine($"Результат умножения: {x * y}\n");
            
            _view.PrintLine("Деление дробей");
            _view.PrintLine($"Вы ввели {x} и {y}");
            _view.PrintLine($"Результат деление: {x / y}");
        }
    }
}