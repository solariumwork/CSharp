namespace Task2
{
    using Person;
    using System;

    static class Program
    {
        private static void Main()
        {
            Person.Person person = PersonFactory.CreateFromConsole();
            
            Console.WriteLine("Ваш индекс массы тела: {0}", person.BodyMassIndex);
        }
    }
}
