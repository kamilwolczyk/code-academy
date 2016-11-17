using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class MainController
    {
        private IValidator validator;
        private IUserRepository model;
        private ConsoleView view;

        private string login;
        private string pass;

        private IPasswordEncryption PasswordEncryption;

        public MainController(IValidator _validator, IUserRepository _model, ConsoleView _view)
        {
            validator = _validator;
            model = _model;
            view = _view;
        }

        public void setPasswordEncryption(IPasswordEncryption _passwordEncryption)
        {
            PasswordEncryption = _passwordEncryption;
        }

        public void MainSite()
        {
            view.MainSite();
            var decision = view.GetDecision();
            if (IsMainDecisionValid(decision))
            {
                ShowSetCredentialsDialogs();
                if (decision == Decision.Login)
                {
                    Login();
                }else if(decision == Decision.Register)
                {
                    Register();
                }
            }
            
        }

        private void Login()
        {
            if (ValidateCheckCredential(login, pass))
            {
                //zalogowany
                view.Logged();
                Wait();
            }
            else
            {
                //nie zalogowany
                view.NotLogged();
                Wait();
                MainSite();
            }
        }

        private void Register()
        {
            if (ValidateAddCredentials(login, pass))
            {
                AddCredentials(login, pass);
                MainSite();
            }
            else
            {
                view.NotCorrect();
                Wait();
                MainSite();
            }
        }

        private void ShowSetCredentialsDialogs()
        {
            view.RegisterLogin();
            login = Console.ReadLine();
            view.RegisterPassword();
            pass = Console.ReadLine();
        }

        private bool IsMainDecisionValid(Decision dec)
        {
            return (dec != Decision.Error);
        }

        private bool ValidateAddCredentials(string login, string password)
        {
            return (!model.IsLogin(login) && validator.Validate(password)) ;
        }

        private bool ValidateCheckCredential(string login, string password)
        {
            return PasswordEncryption.VerifyHashedPassword(model.GetPasswordByLogin(login), password);
        }

        private void AddCredentials(string login, string password)
        {
            model.Add(login, PasswordEncryption.GetHash(password));
        }

        private void Wait()
        {
            view.Wait();
        }
    }
}
