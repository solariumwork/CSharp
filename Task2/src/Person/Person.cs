namespace Task2.Person
{
    using System;
    
    class Person
    {
        public ushort Height { get; set; }
        public ushort Weight { get; set; }
        public double BodyMassIndex { get; }

        public Person(ushort height, ushort weight)
        {
            Height = height;
            Weight = weight;
            BodyMassIndex = Weight / (Math.Pow(Height, 2) / 10000);
        }
    }
}
