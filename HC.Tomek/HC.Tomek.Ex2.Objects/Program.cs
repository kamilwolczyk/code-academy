using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex2.Objects
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var warehouse = new Warehouse();
            var consoleManager = new ConsoleManager();
            consoleManager.DisplayOptions(warehouse);

            
        }
    }
}
