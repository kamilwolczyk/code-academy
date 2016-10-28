using System;
using System.Linq;

namespace Hc.Kamil.Ex0.Introduction
{
    public class ArgumentPresenter : IArgumentPresenter
    {
        public void Show(string[] arguments)
        {
            var items = arguments.Select(argument => new InputArgument(argument)).ToList();

            Console.WriteLine("Exercise 1");
            Console.WriteLine();
            Console.WriteLine($"Today is {DateTime.Now}");
            Console.WriteLine();

            for (var index = 0; index < arguments.Length; index++)
                items.ElementAt(index).Show(index + 1, items.Count());

            Console.Write("Click any key to continue...");
            Console.ReadKey();
        }
    }
}