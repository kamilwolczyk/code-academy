using Hc.Kamil.Ex3.RegistrationForm.Models;

namespace Hc.Kamil.Ex3.RegistrationForm.Repositories
{
    public interface IUserRepository
    {
        User GetUser(string login, string password);

        bool ExistUser(string login);

        void AddUser(User user);
    }
}