using Hc.Kamil.Ex3.RegistrationForm.Helpers;

namespace Hc.Kamil.Ex3.RegistrationForm.Models
{
    public class User
    {
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool IsPasswordValid(IValidationHelper validationHelper)
        {
            return Password != null && Password.Length >= 8 && validationHelper.ContainsDigit(Password);
        }
    }
}