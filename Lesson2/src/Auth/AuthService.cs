using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Lesson2.Auth
{
    public class AuthService
    {
        private const string LOGIN = "root";
        private const string PASSWORD = "GeekBrains";
        
        public string Login(string login, string password)
        {
            if (login == "")
            {
                return "Пожалуйста, введите логин";
            }

            if (password == "")
            {
                return "Пожалуйста, введите пароль";
            }

            if (login != LOGIN && password != PASSWORD)
            {
                return "Некорректный логин или пароль";
            }

            return "";
        }
    }
}