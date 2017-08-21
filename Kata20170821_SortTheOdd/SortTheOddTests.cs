﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void input_3_2_1_should_return_1_2_3()
        {
            SortOddArrayShouldBe(new[] { 1, 2, 3 }, new[] { 3, 2, 1 });
        }

        [TestMethod]
        public void input_3_2_4_1_should_return_1_2_4_3()
        {
            SortOddArrayShouldBe(new[] { 1, 2, 4, 3 }, new[] { 3, 2, 4, 1 });
        }

        [TestMethod]
        public void input_5_3_1_8_0_should_return_1_3_5_8_0()
        {
            SortOddArrayShouldBe(new[] { 1, 3, 5, 8, 0 }, new[] { 5, 3, 1, 8, 0 });
        }

        [TestMethod]
        public void input_5_3_2_8_1_4_should_return_1_3_2_8_5_4()
        {
            SortOddArrayShouldBe(new[] { 1, 3, 2, 8, 5, 4 }, new[] { 5, 3, 2, 8, 1, 4 });
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
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    dic.Add(i, array[i]);
                }
            }

            for (var i = 0; i < dic.Count; i++)
            {
                var item = dic.Where((a, j) => j == i).FirstOrDefault();
                array[item.Key] = dic.OrderBy(a => a.Value).Where((a, j) => j == i).FirstOrDefault().Value;
            }

            return array;
        }
    }
}
