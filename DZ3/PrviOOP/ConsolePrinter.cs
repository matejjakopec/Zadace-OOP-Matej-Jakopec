using System;
using System.Collections.Generic;
using System.Text;

namespace PrviOOP
{
    class ConsolePrinter : IPrinter
    {
        public ConsolePrinter()
        {

        }

        public void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
