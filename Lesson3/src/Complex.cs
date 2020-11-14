namespace Lesson3
{
    public class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static Complex operator +(Complex y, Complex x)
        {
            return new Complex(y.Re + x.Re, y.Im + x.Im);
        }

        public static Complex operator -(Complex y, Complex x)
        {
            return new Complex(y.Re - x.Re, y.Im - x.Im);
        }

        public static Complex operator *(Complex y, Complex x)
        {
            return new Complex(y.Re * x.Re - y.Im * x.Im, y.Re * x.Im + y.Im * x.Re);
        }

        public override string ToString()
        {
            return Re + " + " + Im + "i";
        }
    }
}