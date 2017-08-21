using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170821_SortTheOdd
{
    [TestClass]
    public class SortTheOddTests
    {
        [TestMethod]
        public void input_empty_array_should_return_empty_array()
        {
            SortOddArrayShouldBe(new int[] { }, new int[] { });
        }

        private static void SortOddArrayShouldBe(int[] expected, int[] array)
        {
            var kata = new Kata();
            var actual = kata.SortArray(array);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int[] SortArray(int[] array)
        {
            return array;
        }
    }
}
