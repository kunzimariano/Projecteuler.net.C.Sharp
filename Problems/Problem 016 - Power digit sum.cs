using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Problems
{


    //2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

    //What is the sum of the digits of the number 2^1000?

    public class Problem16
    {
        public void First()
        {
            var bigNumber = new List<int>() { 2 };

            for (int i = 1; i < 1000; i++)
            {
                Calculate(bigNumber);
            }

            int result = 0;

            foreach (var n in bigNumber)
            {
                result += n;
            }
            Console.WriteLine(result);

        }

        private void Calculate(List<int> bigNumber)
        {
            int carry = 0;
            for (int i = 0; i < bigNumber.Count; i++)
            {
                int partial = bigNumber[i] * 2;
                if (0 < carry)
                {
                    partial += carry;
                    carry = 0;
                }

                if (9 < partial)
                {
                    carry = 1;
                    bigNumber[i] = partial - 10;

                }
                else
                {
                    bigNumber[i] = partial;
                }
            }

            if (carry != 0)
                bigNumber.Add(carry);
        }

    }

}
