using System;

namespace ConsoleApp.Problems
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.

    public class Problem1
    {
        private int _result;

        public void Solve()
        {
            SumMultiplesOfThree();
            SumMultiplesOfFive();
            Console.WriteLine(_result);
        }

        private void SumMultiplesOfFive()
        {
            for (int i = 5; i < 1000; i += 5)
                if (!IsMultipleOfThree(i))
                    _result += i;
        }

        private void SumMultiplesOfThree()
        {
            for (int i = 3; i < 1000; i += 3)
                _result += i;
        }

        private bool IsMultipleOfThree(int i)
        {
            return i % 3 == 0;
        }

    }
}
