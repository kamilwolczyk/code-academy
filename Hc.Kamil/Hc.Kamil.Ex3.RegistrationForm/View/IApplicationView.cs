using Hc.Kamil.Ex3.RegistrationForm.Models;

namespace Hc.Kamil.Ex3.RegistrationForm.View
{
    public interface IApplicationView
    {
        ActionResult ShowMenu(bool isUserLoggedIn);

        User GetUserData();

        void Sleep();

        void ShowError(string error);

        void ShowMessage(string message);
    }
}