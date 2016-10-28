using System;
using Hc.Kamil.Ex3.RegistrationForm.Models;

namespace Hc.Kamil.Ex3.RegistrationForm.View
{
    public class WindowsConsoleView : IApplicationView
    {
        private const string Line = "------------------------------------------------------";

        public ActionResult ShowMenu(bool isUserLoggedIn)
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine(Line);
            Console.WriteLine(isUserLoggedIn ? "[1] Logout" : "[1] Login");
            Console.WriteLine("[2] Register");
            Console.WriteLine("[3] Quit");

            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        return isUserLoggedIn ? ActionResult.Logout : ActionResult.Login;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        return ActionResult.Register;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        return ActionResult.Exit;
                }
            }
        }

        public User GetUserData()
        {
            Console.Clear();
            Console.Write("Login: ");
            var login = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();
            return new User(login, password);
        }

        public void Sleep()
        {
            Console.WriteLine();
            Console.WriteLine("Waiting...");
            Console.WriteLine("Pres any key to run");
            Console.ReadKey();
        }

        public void ShowError(string error)
        {
            Console.WriteLine();
            Console.WriteLine($"Error: {error}");
            Console.WriteLine();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine($"Info: {message}");
            Console.WriteLine();
        }
    }
}