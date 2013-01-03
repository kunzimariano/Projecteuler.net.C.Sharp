﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler.net
{
    // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

    public class Problem2
    {

        public static void First()
        {
            int first = 1;
            int second = 2;
            int sum = second;

            while (second < 4000000)
            {
                int temp = first + second;
                first = second;
                second = temp;

                if (second % 2 == 0)
                    sum += second;
            }

            Console.WriteLine(sum);
        }
    }
}
