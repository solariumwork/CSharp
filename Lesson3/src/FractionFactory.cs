using System;
using ViewModule;

namespace Lesson3
{
    public class FractionFactory
    {
        private const int AttemptsLimit = 100;
        
        public Fraction CreateFromView(IView view)
        {
            int i = 0;
            do
            {
                // можно было бы и без try catch обойтись, но не просто же так я Exception делал для Fraction
                try
                {
                    int numerator = view.GetInt("Введите числитель");
                    int denominator = view.GetInt("Введите знаменатель");

                    return new Fraction(numerator, denominator);
                }
                catch (ArgumentException exception)
                {
                    view.PrintLine(exception.Message);
                }
                catch (Exception exception)
                {
                    view.PrintLine("Что-то пошло не так, попробуй позже");
                    i++;
                }
            } while (i < AttemptsLimit);
            
            Console.WriteLine($"Вы исчерпали {AttemptsLimit} попыток");

            return null;
        }
    }
}