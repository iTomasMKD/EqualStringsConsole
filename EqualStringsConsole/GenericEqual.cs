namespace EqualStringsConsole
{
    public class GenericEqual
    {
        public static bool FindEqual(string a, string b)
        {
            if (a is null) return false;
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
