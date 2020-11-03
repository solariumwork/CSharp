namespace Task4
{
    using System;
    
    static class Program
    {
        private static void Main(string[] args)
        {
            // swap with buffer variable
            int a = 5;
            int b = 2;
            int buf;

            buf = a;
            a = b;
            b = buf;
            
            // swap without buffer variable
            int c = 5;
            int d = 2;

            c += d;
            d = c - d;
            c -= d;
        }
    }
}
