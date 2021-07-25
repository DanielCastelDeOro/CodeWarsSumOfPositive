using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace CodeWarsSumOfPositive
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int ExampleTest(int[] arr)
        {
            return Kata.PositiveSum(arr);
        }
        public class Kata
        {
            //You get an array of numbers, return the sum of all of the positives ones.

           // Example[1, -4, 7, 12] => 1 + 7 + 12 = 20 Note: if there is nothing to sum, the sum is default to 0.
            public static int PositiveSum(int[] arr)
            {
                
                var number = arr.Where(n => n > 0).Sum();
                return number;
                
            }
        }
    }
}
