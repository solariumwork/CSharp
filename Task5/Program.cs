namespace Task5
{
    using ConsoleModule;
    using Profile;
    using System;
    using System.Drawing;
    
    class Program
    {
        static void Main(string[] args)
        {
            Profile.Profile profile = ProfileFactory.CreateFromConsole();

            string message = $"name: {profile.Name} surname: {profile.Surname} city: {profile.City}";
            ConsoleOutput.Print(message, new Point(Console.WindowWidth / 2, Console.WindowHeight / 2));
        }
    }
}
