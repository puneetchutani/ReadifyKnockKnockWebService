using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyKnockKnockWebService.Service
{
    public class TriangleType
    {
        /// <summary>
        /// Describe the type of triangle 
        /// </summary>
        /// <param name="a">The length of side 'a'.</param>
        /// <param name="b">The length of side 'b'.</param>
        /// <param name="c">The length of side 'c'.</param>
        /// <returns>Type of triangle.</returns>
        public string WhichTriangleType(int a, int b, int c)
        {
            if (a == b && a == c)
                return "Equilateral triangle";
            else if (a == b || a == c || b == c)
                return "Isoseles triangle";
            else if (a != b && a != c && b != c)
                return "Scalene triangle";
            else if (!IsTriangle(a, b, c))
                return "Not a triangle";

            return "Error";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool IsTriangle(int a, int b, int c)
        {
            bool isTriangle = true;

            if (a <= 0 || b <= 0 || c <= 0)
                isTriangle = false;
            else if (((long)a + b) <= c)
                isTriangle = false;
            else if (((long)a + c) <= b)
                isTriangle = false;
            else if (((long)b + c) <= a)
                isTriangle = false;

            return isTriangle;
        }

    }
}