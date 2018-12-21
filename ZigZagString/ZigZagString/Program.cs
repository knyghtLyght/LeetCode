using System;

namespace ZigZagString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ZigZag("PAYPALISHIRING", 3));
            Console.ReadLine();
        }

        static string ZigZag(string s, int numRows)
        {
            if (numRows <= 1) return s;

            string results = "";

            for (int rowIndex = 0; rowIndex < numRows; rowIndex++)
            {
                for (int stringIndex = 0; stringIndex < s.Length; stringIndex++)
                {
                    results += s[stringIndex];

                }
            }

            return results;
        }
    }
}
