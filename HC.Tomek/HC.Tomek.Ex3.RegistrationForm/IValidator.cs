namespace HC.Tomek.Ex3.RegistrationForm
{
    public interface IValidator
    {
        bool CheckIfLoginExists(User user, IUserRepository database);
        bool CheckPassword(User user, IUserRepository database);
        bool ValidatePassword(User user, IUserRepository database);
    }
}