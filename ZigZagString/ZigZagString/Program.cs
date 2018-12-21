using System;

namespace ZigZagString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ZigZag("PAYPALISHIRING", 3));
            Console.WriteLine("PAHNAPLSIIGYIR");
            Console.ReadLine();
        }

        static string ZigZag(string s, int numRows)
        {
            if (numRows <= 1) return s;

            string results = "";

            for (int rowIndex = 0; rowIndex < numRows; rowIndex++)
            {
                for (int stringIndex = rowIndex; stringIndex < s.Length; stringIndex += 2*(numRows -1))
                {
                    results += s[stringIndex];

                    if (rowIndex > 0 && rowIndex < (numRows -1) && stringIndex + 2 *(numRows - 1 - rowIndex) < s.Length)
                    {
                        results += s[stringIndex + 2 * (numRows - 1 - rowIndex)];
                    }
                }
            }

            return results;
        }
    }
}
