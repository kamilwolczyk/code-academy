using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    public class User
    {
        
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public User()
        {

        }

        public string Login
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool CheckIfLoginExists(User user, IUserRepository database)
        {
            bool _loginOk = true;
            string _userLogin = user.Login;

            try
            {
                if (database.GetUsersList().FirstOrDefault(x => x.Login == _userLogin).Login == null);
            }
            catch (Exception)
            {
                _loginOk = false;
            }
            return _loginOk;
        }
        public bool ValidatePassword(User user, IUserRepository database)
        {
            bool _passwordOK = false;
            string _userPassword = user.Password;

            if (_userPassword.Length > 6)
            {
                if (_userPassword.Any(char.IsDigit)) // alternative version: _userPassword.Any(c => char.IsDigit(c));
                    _passwordOK = true;
            }
            else
                _passwordOK = false;
            return _passwordOK;
        }
        public bool CheckPassword(User user, IUserRepository database)
        {
            bool _passwordOK = false;
            try
            {
                if (database.GetUsersList().FirstOrDefault(x => x.Login == user.Login).Password == user.Password)
                    _passwordOK = true;
            }
            catch (Exception)
            {

                _passwordOK = false;
            }

            return _passwordOK;
        }
    }
}
