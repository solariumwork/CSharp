using System;
using ViewModule;

namespace Lesson3
{
    public class Task1: ITask
    {
        private readonly IView _view;
        
        public Task1(IView view)
        {
            _view = view;
        }

        public void Execute()
        {
            _view.PrintLine("Задача 1: Дописать структуру Complex, добавив метод вычитания, произведение.");
            _view.PrintLine("Добавить диалог с использовованием switch для демонстрации работы класса.\n");

            ConsoleKey key;
            do
            {
                _view.PrintLine("Введите цифру");
                _view.PrintLine("1 - +");
                _view.PrintLine("2 - -");
                _view.PrintLine("3 - *");
                _view.PrintLine("0 - закончить");
                
                switch (key = _view.GetKey())
                {
                    case ConsoleKey.D1:
                        Complex z1 = new Complex(2, 3) + new Complex(3, 4);
                        _view.PrintLine($"\n{z1}\n");
                        break;
                    case ConsoleKey.D2:
                        Complex z2 = new Complex(2, 3) - new Complex(3, 4);
                        _view.PrintLine($"\n{z2}\n");
                        break;
                    case ConsoleKey.D3:
                        Complex z3 = new Complex(2, 3) * new Complex(3, 4);
                        _view.PrintLine($"\n{z3}\n");
                        break;
                }
            } while (key != ConsoleKey.D0);
        }
    }
}