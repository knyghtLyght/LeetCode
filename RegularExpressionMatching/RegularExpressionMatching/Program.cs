using System;
using System.Text.RegularExpressions;

namespace RegularExpressionMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsMatch("aa", "a"));
            Console.WriteLine(IsMatch("aa", "a*"));
            Console.WriteLine(IsMatch("ab", ".*"));
            Console.ReadLine();
        }

        public static bool IsMatch(string s, string p)
        {
            string sPattern = $"^{p}$";

            Regex regMatch = new Regex(sPattern);

            if (regMatch.IsMatch(s)) return true;

            return false;
        }
    }
}
