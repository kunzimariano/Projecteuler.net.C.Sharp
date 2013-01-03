using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler.net
{
    //  By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    //  What is the 10 001st prime number?

    public class Problem7
    {
        public static void First()
        {
            int count = 1;

            for (int i = 3; ; i = i + 2)
            {
                if (IsPrime(i))
                {
                    count++;
                    if (count == 10001)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }

        private static bool IsPrime(long number)
        {
            double top = Math.Sqrt(number);

            if (number % 2 == 0)
                return false;

            for (int j = 3; j <= top; j += 2)
            {
                if (number % j == 0)
                    return false;
            }

            return true;
        }
    }
}
