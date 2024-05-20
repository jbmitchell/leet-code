using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeLibrary.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Easy.Tests
{
    [TestClass()]
    public class MergeSortedArrayTests
    {
        [TestMethod]
        [DataRow(new [] { -1, 0, 0, 3, 3, 3, 0, 0, 0 }, new [] { 1, 2, 2 }, 6, 3, new [] { -1, 0, 0, 1, 2, 2, 3, 3, 3 })]
        [DataRow(new [] { 1, 2, 3, 0, 0, 0 }, new [] { 2, 5, 6 }, 3, 3, new [] { 1, 2, 2, 3, 5, 6 })]
        [DataRow(new [] { 1 }, new int[] { }, 1, 0, new [] { 1 })]
        [DataRow(new [] { 0 }, new [] { 1 }, 0, 1, new [] { 1 })]
        [DataRow(new [] { 1, 0 }, new [] { 2 }, 1, 1, new [] { 1, 2 })]
        public void MergeTest1(int[] nums1, int[] nums2, int m, int n, int[] expected)
        {
            var lib = new MergeSortedArray();
            lib.Merge(nums1, m, nums2, n);
            CollectionAssert.AreEqual(expected, nums1);
        }

    }
}