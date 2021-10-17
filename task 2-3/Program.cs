using System;
using System.Text.RegularExpressions;


namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public static class StringExtension
    {
        public static MatchCollection TimeSearch(this string str)
        {
            var regex = new Regex(@"(([0-1][0-9])|([2][0-3])):[0-6][0-9]");
            return regex.Matches(str);
        }

        public static MatchCollection MacSearch(this string str)
        {
            var regex = new Regex(@"([a-z][a-z]:){3}([0-9][0-9]:){2}[0-9][0-9]", RegexOptions.IgnoreCase);
            return regex.Matches(str);
        }

        public static bool EmailValid(this string str)
        {
            var regex = new Regex(@"[a-z]@[a-z]((.[a-z])|())", RegexOptions.IgnoreCase);
            if (regex.IsMatch(str))
                return true;
            else
                return false;
        }

        public static bool PasswordSafe(this string str)
        {
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=_*)[a-zA-Z\d_]{8,}$");
            if (regex.IsMatch(str))
                return true;
            else
                return false;
        }
    }

}
