namespace HC.Radek.Ex3.RegistrationForm
{
    interface IUserRepository
    {
        void Add(string login, string pass);
        bool IsLogin(string login);
        bool Log(string login, string pass);
        string GetPasswordByLogin(string login);
    }
}