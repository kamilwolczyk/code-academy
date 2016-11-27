using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class Rectangle
    {
        private int _a;
        private int _b;

        public Rectangle (int a, int b)
        {

        }

        public static bool operator> (Rectangle r1, Rectangle r2)
        {
            return r1._a*r1._b > r2._a*r2._b;
        }

        public static bool operator< (Rectangle r1, Rectangle r2)
        {
            return r1._a* r1._b < r2._a * r2._b;
        }


    }
}
