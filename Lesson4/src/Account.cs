namespace Lesson4
{
    public struct Account
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}