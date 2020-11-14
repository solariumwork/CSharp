using System;

namespace ViewModule
{
    public interface IView
    {
        public int GetInt();

        public int GetInt(string str);

        public ConsoleKey GetKey();
        
        public ConsoleKey GetKey(string str);

        public float GetFloat(string str);

        public decimal GetDecimal(string str);

        public string GetString(string str);

        public void Print(string str);

        public void PrintLine(string str);
    }
}