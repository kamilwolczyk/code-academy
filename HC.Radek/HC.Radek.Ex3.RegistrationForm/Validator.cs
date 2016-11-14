using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class Validator:IValidator
    {
        public Boolean Validate(String _password)
        {
            return _password.Length > 6 && _password.Any(char.IsDigit);
        }

    }
}
