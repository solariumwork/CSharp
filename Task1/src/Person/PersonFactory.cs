namespace Task1.Person
{
    using System;
    
    static class PersonFactory
    {
        public static Person CreateFromConsole()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            
            ushort age = 0;
            do {
                Console.WriteLine("Введите возраст");
            } while (!UInt16.TryParse(Console.ReadLine(), out age));
            
            ushort height = 0;
            do {
                Console.WriteLine("Введите рост");
            } while (!UInt16.TryParse(Console.ReadLine(), out height));
            
            ushort weight = 0;
            do {
                Console.WriteLine("Введите вес");
            } while (!UInt16.TryParse(Console.ReadLine(), out weight));
            
            return new Person(name, surname, age, height, weight);
        }
    }
}
