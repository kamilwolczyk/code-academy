﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    class ConsoleManager
    {
        
        public void SelectOption(ConsoleManager konsola, IUserRepository database, IValidator validator)
        {
            int option = 0;
            SHA512 sha512Hash = SHA512.Create();
            HashPassword hashpass = new HashPassword();
            do
            {
                Console.WriteLine("[1] Zaloguj");
                Console.WriteLine("[2] Zarejestruj");
                Console.WriteLine("[3] Wyjdź");
                Console.Write("Wybierz: ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Niepoprawna opcja");
                    Console.ReadKey();
                }
                
                User user = new User();
                
                switch (option)
                {
                    case 1:
                        user = konsola.InputCredentials();
                        user.Password = hashpass.GetHash(sha512Hash, user.Password);
                        if (validator.CheckIfLoginExists(user, database) == true)
                            if (validator.CheckPassword(user, database) == true)
                            {
                                konsola.UserLoginMessage();
                            }
                            else
                            {
                                Console.WriteLine("Hasło niepoprawne");
                                Console.ReadKey();
                            }
                        else
                        {
                            Console.WriteLine("Podany login nie istnieje");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        user = konsola.InputCredentials();
                        if (validator.CheckIfLoginExists(user, database) == false)
                            if (validator.ValidatePassword(user, database))
                            {
                                database.AddUser(user);
                            }
                            else
                            {
                                Console.WriteLine("Hasło musi zawierać co najmniej 7 znaków, w tym jedną cyfrę");
                                Console.ReadKey();
                            }
                        else
                        {
                            Console.WriteLine("Login już istnieje.");
                            Console.ReadKey();
                        }
                        break;

                }
                Console.Clear();
            } while (option!=3);

            Console.WriteLine("-------------------");
            foreach (User u in database.GetUsersList())
            {
                Console.WriteLine(u.Login+" "+u.Password);
            }
        }

        public User InputCredentials()
        {
            User _user = new User();
            Console.WriteLine("Input login: ");
            _user.Login = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input password: ");
            _user.Password = Convert.ToString(Console.ReadLine());
            return _user;
        }

        public void UserLoginMessage()
        {
            Console.WriteLine("JESTEŚ ZALOGOWANY");
            Console.ReadKey();
        }
    }
}
