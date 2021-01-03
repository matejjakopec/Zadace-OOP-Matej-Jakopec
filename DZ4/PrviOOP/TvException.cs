using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PrviOOP
{
    [Serializable]
    class TvException : Exception
    {
        private string message;

        public string Message
        {
            get { return message; }
            private set { message = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }


        public TvException(string message, string title)
        {
            this.message = message;
            this.title = title;
        }
       


    }
}
