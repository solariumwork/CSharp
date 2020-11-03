namespace Task3.Point
{
    using System;
    
    public static class PointFactory
    {
        public static Point CreateFromConsole()
        {
            double x = 0;
            do {
                Console.WriteLine("Введите x");
            } while (!Double.TryParse(Console.ReadLine(), out x));
            
            double y = 0;
            do {
                Console.WriteLine("Введите y");
            } while (!Double.TryParse(Console.ReadLine(), out y));

            Console.WriteLine();
            
            return new Point(x, y);
        }
    }
}
