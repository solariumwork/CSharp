using System;
using System.IO;

namespace Lesson4.Auth
{
    public class AuthService
    {
        private readonly Account[] _accounts = new Account[20];

        public AuthService()
        {
            using (StreamReader sr = new StreamReader("resources/accounts.txt"))
            {
                string line;
                for (var i = 0; (line = sr.ReadLine()) != null; i++)
                {
                    string[] credentials = line.Split(' ');

                    _accounts[i] = new Account(credentials[0], credentials[1]);
                }
            }
        }
        
        public string Login(Account account)
        {
            if (account.Login == "")
            {
                return "Пожалуйста, введите логин";
            }

            if (account.Password == "")
            {
                return "Пожалуйста, введите пароль";
            }

            if (!Array.Exists(_accounts, item => IsCorrectCredentials(account, item)))
            {
                return "Некорректный логин или пароль";
            }

            return "";
        }

        private bool IsCorrectCredentials(Account account, Account existedAccount)
        {
            return existedAccount.Login == account.Login && existedAccount.Password == account.Password;
        }
    }
}