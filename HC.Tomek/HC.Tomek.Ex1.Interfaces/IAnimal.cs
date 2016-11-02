using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex1.Interfaces
{
    interface IAnimal
    {
        string Noise();
        string Name
        {
            get;
            set;
        }
    }
}
