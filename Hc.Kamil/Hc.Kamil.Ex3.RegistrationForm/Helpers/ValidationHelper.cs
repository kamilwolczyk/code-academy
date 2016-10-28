namespace Hc.Kamil.Ex3.RegistrationForm.Helpers
{
    public class ValidationHelper : IValidationHelper
    {
        public bool ContainsDigit(string text)
        {
            foreach (var character in text)
            {
                if(character >= '0' && character <='9')
                    return true;
            }

            return false;
        }
    }
}