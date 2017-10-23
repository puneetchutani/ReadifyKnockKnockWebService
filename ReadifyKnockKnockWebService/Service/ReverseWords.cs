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

            string result = string.Empty;
            var words = str.Split(separator);
            foreach (var word in words)
            {
                Array.Reverse(word.ToCharArray());
                result = result + word;
            }
            return result;
        }
    }
}