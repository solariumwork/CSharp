namespace Task3
{
    using System;
    
    public class Line
    {
        public Point.Point Point1 { get; set; }

        public Point.Point Point2 { get; set; }

        public Line(Point.Point point1, Point.Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public double GetDistance()
        {
            return Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2));
        }
    }
}
