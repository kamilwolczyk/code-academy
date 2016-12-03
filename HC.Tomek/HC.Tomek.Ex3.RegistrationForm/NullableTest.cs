using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    public class NullableTest
    {
        public static void InputInt(int? k)
        {
            Console.WriteLine(k.HasValue?"Varabile is not defined":k.ToString()); //if else
             
        }
    }
}
