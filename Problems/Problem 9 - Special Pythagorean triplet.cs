using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Problems
{
    // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    // a^2 + b^2 = c^2

    // For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

    // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    // Find the product abc.

    public class Problem9
    {
        // always hated Pythagorean triplet, this is pure brute force
        public static void First()
        {
            var p = new int[998];

            for (int i = 1; i < 999; i++)
            {
                p[i - 1] = (int)Math.Pow(i, 2);
            }

            for (int i = 0; i < p.Length; i++)
                for (int j = i + 1; j < p.Length; j++)
                {
                    for (int k = 0; k < p.Length; k++)
                    {
                        if (p[i] + p[j] == p[k] && (i + 1 + j + 1 + k + 1) == 1000)
                        {
                            Console.WriteLine((i + 1) * (j + 1) * (k + 1));
                            break;
                        }

                    }
                }



        }
    }

}
