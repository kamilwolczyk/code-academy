﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository database = new InFileUserRepository();
            IValidator validator = new Validator();
            Console.WriteLine(validator.ToString());
            NullableTest.InputInt(1);
            Console.ReadKey();
            NullableTest.InputInt(null);
            Colour colour = Colour.A;
            Rectangle rectangle1 = new Rectangle(3, 4);
            Rectangle rectangle2 = new Rectangle(5, 4);
            Console.WriteLine(rectangle1>rectangle2);
            //database.ReadUser();

            //ConsoleManager konsola = new ConsoleManager();
            //konsola.SelectOption(new ConsoleManager(), database, validator);
            //Console.WriteLine("Press any key to exit.");


            //foreach (User i in database.GetUsersList())
            //{
            //    Console.WriteLine($"Login: {i.Login} Password: {i.Password}");
            //}
            Console.ReadKey();
        }
    }
}
