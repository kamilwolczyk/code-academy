using System;
using System.IO;
using Hc.Kamil.Ex3.RegistrationForm.Helpers;
using Hc.Kamil.Ex3.RegistrationForm.Models;
using Hc.Kamil.Ex3.RegistrationForm.Repositories;
using Hc.Kamil.Ex3.RegistrationForm.View;

namespace Hc.Kamil.Ex3.RegistrationForm
{
    public class AuthenticationController : IAuthenticationController
    {
        private readonly IApplicationView _view;

        private readonly IUserRepository _userRepository;

        private readonly IValidationHelper _validationHelper;

        public AuthenticationController(IApplicationView view, IUserRepository userRepository, IValidationHelper validationHelper)
        {
            _view = view;
            _userRepository = userRepository;
            _validationHelper = validationHelper;
        }

        public User LoggedUser { get; private set; }

        public void Run()
        {
            while (true)
            {
                try
                {
                    switch (_view.ShowMenu(LoggedUser != null))
                    {
                        case ActionResult.Login:
                            Login();
                            break;
                        case ActionResult.Logout:
                            Logout();
                            break;
                        case ActionResult.Register:
                            Register();
                            break;
                        default:
                            return;
                    }
                }
                catch (Exception exception)
                {
                    _view.ShowError(exception.Message);
                    _view.Sleep();
                }
            }
        }

        private void Login()
        {
            if (LoggedUser != null)
            {
                _view.ShowMessage("You are currently logged in!");
                _view.Sleep();
                return;
            }

            var user = _view.GetUserData();
            var dbUser = _userRepository.GetUser(user.Login, user.Password);

            if (dbUser != null)
                LoggedUser = dbUser;
            else
                throw new InvalidDataException("Incorrect login and/or password");
        }

        private void Logout()
        {
            LoggedUser = null;
        }

        private void Register()
        {
            var user = _view.GetUserData();

            if (_userRepository.ExistUser(user.Login))
                throw new InvalidDataException("User with selected login currently exists in the system");

            if (!user.IsPasswordValid(_validationHelper))
                throw new InvalidDataException("Password is not valid");

            _userRepository.AddUser(user);
        }
    }
}