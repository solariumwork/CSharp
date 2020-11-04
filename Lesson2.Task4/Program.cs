using System;
using Lesson2.Task4.Auth;

namespace Lesson2.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string error;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Convert.ToString(Console.ReadLine());

                Console.WriteLine("\nВведите пароль");
                string password = Convert.ToString(Console.ReadLine());

                error = AuthService.Login(login.Trim(), password.Trim());
                if (error != "")
                {
                    Console.WriteLine($"\nОшибка: {error}");
                }
                
                Console.WriteLine("");
            } while (error != "");
            
            Console.WriteLine("Successful login");
        }
    }
}