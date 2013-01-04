using System;

namespace ConsoleApp.Problems
{
    //The sum of the squares of the first ten natural numbers is,
    //1^2 + 2^2 + ... + 10^2 = 385

    //The square of the sum of the first ten natural numbers is,
    //(1 + 2 + ... + 10)^2 = 55^2 = 3025

    //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

    public class Problem6
    {
        // half brute force, first attempt
        public static void First()
        {
            //sum of the squares
            double sum1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum1 += i * i;
            }

            // square of the sum
            double sum2 = SquareOfSum(100);

            Console.WriteLine(sum2 - sum1);
        }

        // no brute force, proper solution
        public static void Second()
        {
            Console.WriteLine(SquareOfSum(100) - SumOfSquares(100));
        }

        private static double SquareOfSum(double n)
        {
            return Math.Pow(n * (n + 1) / 2, 2);
        }

        private static double SumOfSquares(double n)
        {
            return (2 * n + 1) * (n + 1) * n / 6;
        }
    }
}
