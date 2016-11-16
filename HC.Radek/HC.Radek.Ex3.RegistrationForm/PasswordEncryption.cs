using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace HC.Radek.Ex3.RegistrationForm
{
    class PasswordEncryption : IPasswordEncryption
    {

        public string GetHash(string value)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] bytes = provider.ComputeHash(new UTF8Encoding().GetBytes(value));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }

            return hash.ToString();
        }

    }
}
