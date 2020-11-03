namespace Task2.Person
{
    using System;
    
    static class PersonFactory
    {
        public static Person CreateFromConsole()
        {
            ushort height = 0;
            do
            {
                Console.WriteLine("Введите рост (см)");
            } while (!UInt16.TryParse(Console.ReadLine(), out height));

            ushort weight = 0;
            do
            {
                Console.WriteLine("Введите вес (кг)");
            } while (!UInt16.TryParse(Console.ReadLine(), out weight));

            Console.WriteLine();

            return new Person(height, weight);
        }
    }
}
