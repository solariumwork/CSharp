namespace Task3
{
    using Point;
    using System;

    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите первую точку:");
            Point.Point point1 = PointFactory.CreateFromConsole();
            
            Console.WriteLine("Введите вторую точку:");
            Point.Point point2 = PointFactory.CreateFromConsole();
            
            Line line = new Line(point1, point2);
            Console.WriteLine("Расстояние между точками:");
            Console.WriteLine($"{line.GetDistance():0.00}");
        }
    }
}
