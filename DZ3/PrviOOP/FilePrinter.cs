using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PrviOOP
{
    class FilePrinter : IPrinter
    {

        private string filename;

        public string Filename
        {
            get { return filename; }
            private set { filename = value; }
        }

        public FilePrinter(string filename)
        {
            this.filename = filename;
        }
        public void Print(string input)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(input);
            }
        }
       
    }
}
