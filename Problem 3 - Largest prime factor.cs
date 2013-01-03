using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler.net
{
    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?
    public class Problem3
    {
        public static void First()
        {
            const long n = 600851475143;
            long largest = 0;
            var topPrime = (long)Math.Sqrt(n);


            for (int i = 2; i < topPrime; i++)
            {
                // if prime and factor of the enumer
                if (IsPrime(i) && (n % i == 0))
                    largest = i;
            }

            Console.WriteLine(largest);
        }

        private static bool IsPrime(long number)
        {
            var top = (long)Math.Sqrt(number);

            if (number % 2 == 0)
                return false;

            for (int j = 3; j < top; j += 2)
            {
                if (number % j == 0)
                    return false;
            }

            return true;
        }
    }
}
