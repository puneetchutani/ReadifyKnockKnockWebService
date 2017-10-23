using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadifyKnockKnockWebServiceTests.KnockService;

namespace ReadifyKnockKnockWebServiceTests
{
    [TestClass]
    public class ReadifyUnitTests
    {
        [TestMethod]
        public void GetYourToken()
        {
            KnockClient client = new KnockClient();
            var guid = client.GetToken();
            Assert.IsTrue(guid.ToString().Equals("d28eb908-a8fc-49e7-ad6b-0fa92da4890f"));
            client.Close();
        }

        [TestMethod]
        public void FibonacciNumber()
        {
            KnockClient client = new KnockClient();

            var test1 = client.Fibonacci(5);
            var test2 = client.Fibonacci(0);
            var test3 = client.Fibonacci(1);
            var test4 = client.Fibonacci(2);
            var test5 = client.Fibonacci(9);
            var test6 = client.Fibonacci(10);
            var test7 = client.Fibonacci(-5);
            var test8 = client.Fibonacci(-1);
            var test9 = client.Fibonacci(55);
            var test10 = client.Fibonacci(85);

            long? test11 = null;
            try
            {
                test11 = client.Fibonacci(93);
            }
            catch (Exception ex) 
            {
            }

            Assert.IsTrue(test1 == 5);
            Assert.IsTrue(test2 == 0);
            Assert.IsTrue(test3 == 1);
            Assert.IsTrue(test4 == 1);
            Assert.IsTrue(test5 == 34);
            Assert.IsTrue(test6 == 55);
            Assert.IsTrue(test7 == 5);
            Assert.IsTrue(test8 == 1);
            Assert.IsTrue(test9 == 139583862445);
            Assert.IsTrue(test11 == null);

            client.Close();
        }

        [TestMethod]
        public void ReverseWords()
        {
            KnockClient client = new KnockClient();

            string test1 = null;
            try
            {
                test1 = client.ReverseWords(null);
            }
            catch (Exception ex) 
            {
            }

            var test2 = client.ReverseWords(" ");
            var test3 = client.ReverseWords("hello");
            var test4 = client.ReverseWords("Implementation Notes ");
            var test5 = client.ReverseWords("hello  there");
            var test6 = client.ReverseWords(string.Empty);
            var test7 = client.ReverseWords(" starting spaces");
            var test8 = client.ReverseWords("EVERYTHING IS CAPITAL");

            Assert.IsTrue(test1 == null);
            Assert.IsTrue(test2.Equals(" "));
            Assert.IsTrue(test3.Equals("olleh"));
            Assert.IsTrue(test4.Equals("noitatnemelpmI setoN "));
            Assert.IsTrue(test5.Equals("olleh  ereht"));
            Assert.IsTrue(test6.Equals(string.Empty));
            Assert.IsTrue(test7.Equals(" gnitrats secaps"));
            Assert.IsTrue(test8.Equals("GNIHTYREVE SI LATIPAC"));

            client.Close();
        }

        [TestMethod]
        public void WhatShapeIsThis()
        {
            KnockClient client = new KnockClient();

            var test1 = client.TriangleType(0, 0, 0);
            var test2 = client.TriangleType(1, 1, 2);
            var test3 = client.TriangleType(-1, 0, 1);
            var test4 = client.TriangleType(-1, -1, -1);
            var test5 = client.TriangleType(1, 1, -1);
            var test6 = client.TriangleType(-2147483648, -2147483648, -2147483648);

            var test7 = client.TriangleType(2, 2, 2);
            var test8 = client.TriangleType(2147483647, 2147483647, 2147483647);

            var test9 = client.TriangleType(13, 13, 5);
            var test10 = client.TriangleType(50, 12, 50);

            var test11 = client.TriangleType(3, 4, 5);
            var test12 = client.TriangleType(4, 5, 3);
            
            Assert.IsTrue(test1 == "Not a triangle");
            Assert.IsTrue(test2 == "Not a triangle");
            Assert.IsTrue(test3 == "Not a triangle");
            Assert.IsTrue(test4 == "Not a triangle");
            Assert.IsTrue(test5 == "Not a triangle");
            Assert.IsTrue(test6 == "Not a triangle");

            Assert.IsTrue(test7 == "Equilateral triangle");
            Assert.IsTrue(test8 == "Equilateral triangle");

            Assert.IsTrue(test9 == "Isoseles triangle");
            Assert.IsTrue(test10 == "Isoseles triangle");

            Assert.IsTrue(test11 == "Scalene triangle");
            Assert.IsTrue(test12 == "Scalene triangle");

            client.Close();
        }
    }

}
