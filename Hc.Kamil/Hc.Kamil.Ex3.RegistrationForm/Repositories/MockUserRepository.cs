using System;
using System.Collections.Generic;
using Hc.Kamil.Ex3.RegistrationForm.Models;

namespace Hc.Kamil.Ex3.RegistrationForm.Repositories
{
    public class MockUserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public User GetUser(string login, string password)
        {
            var dbUser = GetUserByLogin(login);

            return dbUser != null && dbUser.Password == password ? dbUser : null;
        }

        public bool ExistUser(string login)
        {
            var user = GetUserByLogin(login);
            return user != null;
        }

        public void AddUser(User user)
        {
            if (GetUserByLogin(user.Login) != null)
                throw new InvalidOperationException($"User login {user.Login} is not available.");

            _users.Add(user);
        }

        private User GetUserByLogin(string login)
        {
            foreach (var user in _users)
            {
                if (user.Login == login)
                    return user;
            }
            return null;
        }
    }
}