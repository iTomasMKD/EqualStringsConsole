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

            //instance call
            Program pr = new Program();
            bool z = pr.FindEqual(a, b);
            Console.WriteLine(z);

            //generic call extension method
            Func<string, string, bool> equal = GenericEqual.FindEqual;
            bool x = equal(a, b);
            Console.WriteLine(x);

            //using lambda
            Func<string, string, bool> replaceExtra = (a, b) => a == b;
            Console.WriteLine(replaceExtra(a, b));
            }
    }
}
