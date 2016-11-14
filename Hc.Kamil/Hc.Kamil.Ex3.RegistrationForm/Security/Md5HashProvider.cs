using System.Security.Cryptography;
using System.Text;

namespace Hc.Kamil.Ex3.RegistrationForm.Security
{
    public class Md5HashProvider : IHashProvider
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