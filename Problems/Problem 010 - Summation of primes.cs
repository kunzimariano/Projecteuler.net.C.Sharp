using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Problems
{
    // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    // Find the sum of all the primes below two million.
    public class Problem10
    {
        public static void First()
        {
            long total = 5;
            int i = 5;
            while (i < 2000000)
            {
                if (Helpers.Math.IsPrime(i))
                    total += i;

                // all primes greater than 3 can be written in the form 6k+/-1.
                if (Helpers.Math.IsPrime(i + 2))
                    total += i + 2;

                i += 6;
            }

            Console.WriteLine(total);

        }
    }
}
