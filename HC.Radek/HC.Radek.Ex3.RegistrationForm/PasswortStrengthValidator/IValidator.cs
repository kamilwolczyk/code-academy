using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    interface IValidator
    {
        bool Validate(string password);
    }
}
