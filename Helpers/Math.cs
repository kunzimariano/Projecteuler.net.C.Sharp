using System;
using System.Collections.Generic;

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
                i += 6;
            }

            return true;
        }

        public static bool IsFactor(long n, long factor)
        {
            if (n % factor == 0)
                return true;
            return false;
        }

        public static long GetNPrime(long n)
        {
            if (n < 2)
                throw new ArgumentException("N should be greater than 1.", "n");

            int count = 1;

            for (int i = 3; ; i = i + 2)
            {
                if (IsPrime(i))
                {
                    count++;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }

        }

        public static List<int> GetFirstNPrimes(int n)
        {
            if (n < 2)
                throw new ArgumentException("N should be greater than 1.", "n");

            int count = 1;

            var result = new List<int>() { 2 };

            for (int i = 3; ; i = i + 2)
            {
                if (IsPrime(i))
                {
                    count++;
                    result.Add(i);
                    if (count == n)
                    {
                        return result;
                    }
                }
            }
        }

        public static long Factorial(long n)
        {
            long result = n;

            for (long i = n - 1; 0 < i; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
