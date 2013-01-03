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

            Console.WriteLine("First: " + largest);
        }


        public static void Second()
        {
            long n = 600851475143;
            long largest = 0;
            long factor = 2;
            var topPrime = (long)Math.Sqrt(n);

            // for 2
            while (1 < n && factor < topPrime)
            {
                while (IsFactor(factor, ref n))
                {
                    largest = factor;
                }

                factor += 1;
            }

            // for odds
            while (1 < n && factor < topPrime)
            {
                while (IsFactor(factor, ref n))
                {
                    largest = factor;
                }

                factor += 2;
            }

            Console.WriteLine("Second: " + largest);
        }

        private static bool IsFactor(long factor, ref long n)
        {
            if (n % factor == 0)
            {
                n = n / factor;
                return true;
            }

            return false;
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
