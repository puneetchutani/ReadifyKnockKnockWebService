using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyKnockKnockWebService.Service
{
    public class ReverseWords
    {
        private char[] separator = { ' ' };

        /// <summary>
        /// Reverses words in the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>The string with reversed words.</returns>
        public string StringReverse(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("Value cannot be null.");
            }

            var reversedWords = string.Join(" ",
                                str.Split(' ')
                                .Select(x => new String(x.Reverse().ToArray()))
                                .ToArray());
            return reversedWords;
        }
    }
}