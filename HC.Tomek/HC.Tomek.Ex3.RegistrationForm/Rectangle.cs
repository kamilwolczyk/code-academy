using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    public class Rectangle
    {
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public int A { get; set; }
        public int B { get; set; }
        public static bool operator > (Rectangle r1, Rectangle r2)
        {
            return r1.A*r1.B > r2.A*r2.B;
        }
        public static bool operator < (Rectangle r1, Rectangle r2)
        {
            return r1.A * r1.B < r2.A * r2.B;
        }
    }
}
