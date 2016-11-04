using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static Controler controler;
        private static Model model;
        private static View view;

        static void Main(string[] args)
        {
            model = (Model) Activator.CreateInstance(typeof(Model));
            view = (View)Activator.CreateInstance(typeof(View));
            controler = (Controler)Activator.CreateInstance(typeof(Controler), view, model);
            controler.MainSite();
        }

        
    }
}
