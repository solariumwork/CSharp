using System;
using System.IO;
using Lesson4.Auth;
using ViewModule;

namespace Lesson4
{
    public class Task3: ITask
    {
        private readonly IView _view;
        private readonly AuthService _authService;
        
        public Task3(IView view, AuthService authService)
        {
            _view = view;
            _authService = authService;
        }

        public void Execute()
        {
            _view.PrintLine("Задача 3: Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.");
            _view.PrintLine("Создайте структуру Account, содержащую Login и Password.");

            string error;
            do
            {
                string login = _view.GetString("Введите логин").Trim();
                string password = _view.GetString("\nВведите пароль").Trim();
                Account account = new Account(login, password);

                error = _authService.Login(account);
                if (error != "")
                {
                    _view.PrintLine($"\nОшибка: {error}");
                }

                _view.PrintLine("");
            } while (error != "");
            
            _view.PrintLine("Вы успешно авторизовались");
        }
    }
}