using Hc.Kamil.Ex3.RegistrationForm.Helpers;
using Hc.Kamil.Ex3.RegistrationForm.Repositories;
using Hc.Kamil.Ex3.RegistrationForm.View;

namespace Hc.Kamil.Ex3.RegistrationForm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IUserRepository userRepository = new MockUserRepository();
            IApplicationView view = new WindowsConsoleView();
            IValidationHelper validationHelper = new ValidationHelper();

            IAuthenticationController authenticationController = new AuthenticationController(view, userRepository, validationHelper);
            authenticationController.Run();
        }
    }
}