using System;

namespace ConsoleApp.Problems
{
    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?
    public class Problem3
    {
        private static long _number;
        private static long _largestPrimeFactor;
        private static long _currentPrimeFactor;
        private static long _primeBoundary;

        private static void Initialize()
        {
            _number = 600851475143;
            _largestPrimeFactor = 0;
            _currentPrimeFactor = 2;
            _primeBoundary = (long)Math.Sqrt(_number);
        }

        public static void Solve()
        {
            Initialize();

            while (IsNumberBiggerThanOneAndBelowPrimeBondary())
            {
                if (IsCurrentFactorLarger())
                    DivideByCurrentFactorAsMuchAsPosible();
                IncreaseCurrentPrimeFactor();
            }

            Console.WriteLine("Second: " + _largestPrimeFactor);
        }

        private static bool IsNumberBiggerThanOneAndBelowPrimeBondary()
        {
            return 1 < _number && _currentPrimeFactor < _primeBoundary;
        }

        private static bool IsCurrentFactorLarger()
        {
            if (Helpers.Math.IsFactor(_number, _currentPrimeFactor))
            {
                _largestPrimeFactor = _currentPrimeFactor;
                return true;
            }
            return false;

        }

        private static void DivideByCurrentFactorAsMuchAsPosible()
        {
            while (Helpers.Math.IsFactor(_number, _currentPrimeFactor))
            {
                _number = _number / _currentPrimeFactor;
            }
        }

        private static void IncreaseCurrentPrimeFactor()
        {
            if (_currentPrimeFactor == 2)
                _currentPrimeFactor += 1;
            else
                _currentPrimeFactor += 2;
        }
    }
}
