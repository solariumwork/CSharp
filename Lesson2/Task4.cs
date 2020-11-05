using System;
using Lesson2.Auth;

namespace Lesson2
{
    public class Task4
    {
        private View View { get; }
        private AuthService AuthService { get; }
        public Task4(View view, AuthService authService)
        {
            View = view;
            AuthService = authService;
        }
        
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Задача 4: Проверка логина и пароля\n");
            Console.WriteLine("Правильный логин: root\n");
            Console.WriteLine("Правильный пароль: GeekBrains\n");
            
            string error;
            do
            {
                string login = View.GetString("Введите логин");
                string password = View.GetString("\nВведите пароль");

                error = AuthService.Login(login.Trim(), password.Trim());
                if (error != "")
                {
                    Console.WriteLine($"\nОшибка: {error}");
                }
                
                Console.WriteLine("");
            } while (error != "");
            
            Console.WriteLine("Вы успешно авторизовались");
        }
    }
}