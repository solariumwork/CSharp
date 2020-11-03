namespace Task5.ConsoleModule
{
    using System;
    using System.Drawing;
    
    public static class ConsoleOutput
    {
        public static void Print(string message, Point point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine(message);
        }
    }
}
