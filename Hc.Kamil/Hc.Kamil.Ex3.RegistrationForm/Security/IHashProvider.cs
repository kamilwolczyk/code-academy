namespace Hc.Kamil.Ex3.RegistrationForm.Security
{
    public interface IHashProvider
    {
        string GetHash(string value);
    }
}