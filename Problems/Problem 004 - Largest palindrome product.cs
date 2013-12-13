using System;

namespace ConsoleApp.Problems
{
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.
    public class Problem4
    {
        public static void First()
        {
            int largestPalindrome = 0;
            // TODO: this needs more refactoring
            for (int i = 999; i > 99; i -= 2)
                for (int j = i - 1; j > 99; j--)
                {
                    int palindromeCandidate = i * j;
                    if (IsPalindrome(palindromeCandidate) && largestPalindrome < palindromeCandidate)
                    {
                        largestPalindrome = palindromeCandidate;
                        break;
                    }
                }
            Console.WriteLine(largestPalindrome);
        }

        private static bool IsPalindrome(int candidate)
        {
            string s = candidate.ToString();
            if (IsEven(s))
                return CheckEven(s);
            return CheckOdd(s);
        }

        private static bool IsEven(string s)
        {
            return s.Length % 2 == 0;
        }

        private static bool CheckEven(string s)
        {
            int end = s.Length - 1;
            int leftLimit = end / 2;

            for (int i = 0, j = end; i <= leftLimit; i++, j--)
                if (s[i] != s[j])
                    return false;
            return true;
        }

        private static bool CheckOdd(string s)
        {
            int end = s.Length - 1;
            int leftLimit = end / 2 - 1;

            for (int i = 0, j = end; i <= leftLimit; i++, j--)
                if (s[i] != s[j])
                    return false;
            return true;
        }
    }
}
