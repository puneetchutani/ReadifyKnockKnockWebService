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

            int a = 0, b = 1, c = 0;
            for (int i = 2; i < num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}