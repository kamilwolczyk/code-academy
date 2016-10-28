using System;

namespace Hc.Kamil.Ex0.Introduction
{
    public class InputArgument : IArgument
    {
        private const string Line = "------------------------------------------";

        private readonly string _value;

        public InputArgument(string value)
        {
            _value = value;
        }

        public void Show(int index, int total)
        {
            Console.WriteLine(Line);
            Console.WriteLine($"Argument {index} of {total}");
            Console.WriteLine($"Value: {_value}");

            if (index == total)
            {
                Console.WriteLine(Line);
                Console.WriteLine();
            }
        }
    }
}