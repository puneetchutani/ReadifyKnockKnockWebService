using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyKnockKnockWebService.Service
{
    public class Fibonacci
    { 
        /// <summary>
        /// The boundary value of Fibonacci number in long is 92.
        /// </summary>
        protected readonly long Max = 92;

        /// <summary>
        /// Calculates the Fibonacci number.
        /// </summary>
        /// <param name="n">Index.</param>
        /// <returns>The Fibonacci number at a particular position.</returns>
        public long FibonacciNumber(long num)
        {
            if (num > Max || num < -Max)
                throw new ArgumentOutOfRangeException(String.Format("The index cannot exeed {0} or cannot be less than -{0}",Max));

            long sum = 0, a = 1, b = 1;
            int i = 2;
            var number = Math.Abs(num);

            if (number == 1 || number == 0)
                return number;
            else
            {
                if (number == 2)
                    return 1;
                else
                {
                    while (i != number)
                    {
                        sum = a + b;
                        a = b;
                        b = sum;
                        ++i;
                    }
                    if (num < 0 && num % 2 == 0)
                        return -sum;
                    else
                        return sum;
                }
            }
        }
    }
}