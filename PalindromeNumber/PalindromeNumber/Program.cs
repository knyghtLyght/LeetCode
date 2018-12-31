using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine();
            Console.WriteLine(IsPalindrome(-121));
            Console.WriteLine();
            Console.WriteLine(IsPalindrome(10));
            Console.ReadLine();
        }

        //First pass solution. Clear and quick but more memory than is strictly needed
        public static bool IsPalindrome(int x)
        {
            string strNum = x.ToString();

            char[] strArr = strNum.ToCharArray();

            Array.Reverse(strArr);

            if (strNum == new string(strArr)) return true;

            return false;
        }

        //Provided solution
        public static bool IsPalindromeTwo(int x)
        {
            // Negative numbers can be a palindrome by the definition we are given in the problem
            // If x mod 10 is 0 we would have to have a leading 0 for our number to be a palindrome
            // Since the only number that would let that happen would be 0 we have the second case here.
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
