using ReadifyKnockKnockWebService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ReadifyKnockKnockWebService
{
    /// <summary>
    /// This represents the readify service contract.
    /// </summary>
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net", IncludeExceptionDetailInFaults = true)]
    public class Knock : IKnock
    {
        // This token is associated with puneet@smarttrade.biz
        protected Guid token = new Guid("d28eb908-a8fc-49e7-ad6b-0fa92da4890f");

        /// <summary>
        /// Get the token.
        /// </summary>
        /// <returns>My token.</returns>
        public Guid GetToken()
        {
            return this.token;
        }

        /// <summary>
        /// Calculate the fibonicci number.
        /// </summary>
        /// <param name="n">Index.</param>
        /// <returns>returns the number at nth position in the Fibonacci sequence.</returns>
        public long Fibonacci(long n)
        {
            long result = 0;

            try
            {
                result = new Fibonacci().FibonacciNumber(n);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
            catch (Exception exception) { }

            return result;
        }

        /// <summary>
        /// Reverses the words.
        /// </summary>
        /// <param name="s">The source string.</param>
        /// <returns>The source string where words are reversed.</returns>
        public string ReverseWords(string s)
        {
            string result = string.Empty;
            try
            {
                result = new ReverseWords().StringReverse(s);
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (Exception e) { }
            return result;
        }

        /// <summary>
        /// Classify the type of a triangle.
        /// </summary>
        /// <param name="a">Length of side 'a'.</param>
        /// <param name="b">Length of side 'b'.</param>
        /// <param name="c">Length of side 'c'.</param>
        /// <returns>The <see cref="TriangleType"/> type.</returns>
        public string TriangleType(int a, int b, int c)
        {
            string result = string.Empty;
            try
            {
                result = new TriangleType().WhichTriangleType(a, b, c);
            }
            catch (Exception exception) { }
            return result;
        }
    }
}
