using System;

namespace EqualStringsConsole
{
    class Program
    {
        public bool FindEqual(string a, string b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            static void Main(string[] args)
        {
            string a = "y";
            string b = "y";
            Program pr = new Program();
            bool z = pr.FindEqual(a, b);
            Console.WriteLine(z);
        }
    }
}
