using System;

namespace ConsoleApp.Problems
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
                if (Helpers.Math.IsPrime(i) && (n % i == 0))
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
    }
}
