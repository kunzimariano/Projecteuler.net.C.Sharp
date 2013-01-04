using System;

namespace ConsoleApp.Problems
{
    // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

    public class Problem5
    {
        // 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 

        public static void First()
        {
            int[] divisors = { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11 };
            int candidate = 20;

            while (true)
            {
                bool foundIt = true;

                foreach (var divisor in divisors)
                {
                    if (candidate % divisor != 0)
                    {
                        foundIt = false;
                        break;
                    }
                }

                if (foundIt)
                {
                    Console.WriteLine(candidate);
                    break;
                }

                candidate += 2;
            }

        }
    }
}
