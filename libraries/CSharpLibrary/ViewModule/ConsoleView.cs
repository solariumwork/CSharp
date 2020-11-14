using System;

namespace ViewModule
{
    public class ConsoleView: IView
    {
        public int GetInt()
        {
            int result;
            while (!Int32.TryParse(Console.ReadLine(), out result)) {}

            return result;
        }

        public int GetInt(string str)
        {
            int result;
            do {
                Console.WriteLine(str);
            } while (!Int32.TryParse(Console.ReadLine(), out result));

            return result;
        }
        
        public ConsoleKey GetKey()
        {
            return Console.ReadKey().Key;
        }

        public ConsoleKey GetKey(string str)
        {
            Console.WriteLine(str);
            return Console.ReadKey().Key;
        }

        public float GetFloat(string str)
        {
            float result;
            do {
                Console.WriteLine(str);
            } while (!Single.TryParse(Console.ReadLine(), out result));

            return result;
        }

        public decimal GetDecimal(string str)
        {
            decimal result;
            do {
                Console.WriteLine(str);
            } while (!Decimal.TryParse(Console.ReadLine(), out result));

            return result;
        }

        public string GetString(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }

        public void Print(string str)
        {
            Console.Write(str);
        }

        public void PrintLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}