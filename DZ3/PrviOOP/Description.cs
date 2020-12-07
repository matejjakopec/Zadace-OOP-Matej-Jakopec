using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PrviOOP
{
    class Description
    {
        private int number;
        TimeSpan length = new TimeSpan();
        private string name;

        public Description(int number, TimeSpan length, string name)
        {
            this.number = number;
            this.length = length;
            this.name = name;
        }

        public int GetNumber()
        {
            return number;
        }

        public TimeSpan GetLength()
        {
            return length;
        }

        public string GetName()
        {
            return name;
        }
    }
}
