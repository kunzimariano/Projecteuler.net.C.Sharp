using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler.net
{
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.
    public class Problem4
    {
        public static void First()
        {
            int largest = 0;

            for (int i = 999; i > 99; i -= 2)
                for (int j = i - 1; j > 99; j--)
                {
                    int pal = i * j;
                    if (IsPalindrome(pal) && largest < pal)
                    {
                        largest = pal;
                        break;
                    }

                }

            Console.WriteLine(largest);

        }

        private static bool IsPalindrome(int pal)
        {
            string s = pal.ToString();
            //zero-indexed end of the string
            int end = s.Length - 1;
            int leftLimit;


            // even
            if (s.Length % 2 == 0)
            {
                leftLimit = end / 2;

                for (int i = 0, j = end; i <= leftLimit; i++, j--)
                    if (s[i] != s[j])
                        return false;
                return true;
            }
            // odd
            else
            {
                leftLimit = end / 2 - 1;

                for (int i = 0, j = end; i <= leftLimit; i++, j--)
                    if (s[i] != s[j])
                        return false;
                return true;

            }
        }
    }
}
