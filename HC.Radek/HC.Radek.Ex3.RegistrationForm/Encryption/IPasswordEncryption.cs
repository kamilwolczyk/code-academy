﻿namespace HC.Radek.Ex3.RegistrationForm
{
    interface IPasswordEncryption
    {
        string GetHash(string value);
        bool VerifyHashedPassword(string encryptedPassword, string Password);
    }
}