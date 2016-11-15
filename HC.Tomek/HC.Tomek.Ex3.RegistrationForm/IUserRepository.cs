using System.Collections.Generic;

namespace HC.Tomek.Ex3.RegistrationForm
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void ReadUser();
        IEnumerable<User> GetUsersList();

    }
}