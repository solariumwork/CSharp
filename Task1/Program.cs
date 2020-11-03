namespace Task1
{
    using Person;
    using System;

    static class Program
    {
        private static void Main()
        {
            Person.Person person = PersonFactory.CreateFromConsole();
            
            Console.WriteLine("");
            Console.WriteLine("Склеивание:");
            Console.WriteLine(PersonFormatter.Concatenate(person));
            
            Console.WriteLine("");
            Console.WriteLine("Форматированный вывод:");
            Console.WriteLine(PersonFormatter.Format(person));
            
            Console.WriteLine("");
            Console.WriteLine("Вывод через $");
            Console.WriteLine(PersonFormatter.FormatViaDollar(person));
        }
    }
}
