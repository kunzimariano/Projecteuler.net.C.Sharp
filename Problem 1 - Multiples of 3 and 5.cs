﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler.net
{
    public class Problem1
    {
        public static void Multiplesof3And5()
        {
            int result = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }

            Console.WriteLine(result);
            Console.Read();
        }

    }
}
