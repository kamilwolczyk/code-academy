using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex0.Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Exercise 1"+"\n\nToday is: "+DateTime.Now+"\n");
           
            foreach (string element in args)
            {
                System.Console.WriteLine("--------------------");
                System.Console.WriteLine("Argument "+(Array.IndexOf(args,element)+1)+" of "+args.Length);
                System.Console.WriteLine("Value: "+element); 
            }
            System.Console.WriteLine("--------------------"+"\n\n"+ "Click any key to continue ...");
            System.Console.ReadKey();
        }
    }
}
