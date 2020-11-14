using System;

namespace Lesson3
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть 0");
            }
            
            _numerator = numerator;
            _denominator = denominator;
            
            Simplify(this);
        }
        
        public static Fraction operator +(in Fraction x, in Fraction y)
        {
            int commonDenomination = x.GetCommonDenomination(y);

            int xMultiple = commonDenomination / x._denominator;
            int yMultiple = commonDenomination / y._denominator;

            return new Fraction(x._numerator * xMultiple + y._numerator * yMultiple, x._denominator * xMultiple);
        }
        
        public static Fraction operator -(in Fraction x, in Fraction y)
        {
            int commonDenomination = x.GetCommonDenomination(y);

            int xMultiple = commonDenomination / x._denominator;
            int yMultiple = commonDenomination / y._denominator;

            return new Fraction(x._numerator * xMultiple - y._numerator * yMultiple, x._denominator * xMultiple);
        }

        public static Fraction operator *(in Fraction x, in Fraction y)
        {
            return new Fraction(x._numerator * y._numerator, x._denominator * y._denominator);
        }

        public static Fraction operator /(in Fraction x, in Fraction y)
        {
            return new Fraction(x._numerator * y._denominator, x._denominator * y._numerator);
        }

        private void Simplify(Fraction x)
        {
            for (var divider = 2; divider < 10; divider++)
            {
                while (x._numerator % divider == 0 && x._denominator % divider == 0)
                {
                    x._numerator /= divider;
                    x._denominator /= divider;
                }
            }
        }

        private int GetCommonDenomination(Fraction y)
        {
            return _denominator * y._denominator;
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
    }
}