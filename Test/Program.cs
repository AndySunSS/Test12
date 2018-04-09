//using System;
//using System.Xml;
using ClassLibrary1;

namespace Test
{
    public class Program
    {
        private int _secret;

        public int Secret
        {
            get { return --_secret; }
            set { _secret = value; }
        }


        static void Main(string[] args)
        {
        }

        
    }
}
