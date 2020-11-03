namespace Task5.Profile
{
    using System;
    
    public static class ProfileFactory
    {
        public static Profile CreateFromConsole()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            
            return new Profile(name, surname, city);
        }
    }
}
