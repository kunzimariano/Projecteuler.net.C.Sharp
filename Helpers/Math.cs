using System;

namespace ConsoleApp.Helpers
{
    public static class Math
    {
        public static bool IsPrime(long n)
        {
            if (n <= 1)
                return false;
            // 2, 3
            if (n <= 3)
                return true;
            // even numbers are not prime except for 2
            if (n % 2 == 0)
                return false;

            if (n % 3 == 0)
                return false;

            double top = System.Math.Sqrt(n);

            int i = 5;

            while (i <= top)
            {
                if (n % i == 0)
                    return false;
                // all primes greater than 3 can be written in the form 6k+/-1.
                if (n % (i + 2) == 0)
                    return false;
                i += 2;
            }

            return true;
        }

        public static bool IsFactor(long factor, ref long n)
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
