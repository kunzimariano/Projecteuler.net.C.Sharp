using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler.net
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.

    public class Problem1
    {
        // first attempt
        public static void First()
        {
            int result = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }

            Console.WriteLine(result);
        }

        // a more efficient approach
        public static void Second()
        {
            int result = 0;

            // multiples of 3
            for (int i = 3; i < 1000; i += 3)
                result += i;

            // multiples of 5, avoid the already added multiple of 3
            for (int i = 5; i < 1000; i += 5)
                if (i % 3 != 0)
                    result += i;

            Console.WriteLine(result);
        }

    }
}
