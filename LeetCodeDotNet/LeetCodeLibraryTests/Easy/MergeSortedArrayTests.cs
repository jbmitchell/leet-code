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
        [TestMethod()]
        public void MergeTest1()
        {
            int[] nums1 = { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            int[] nums2 = { 1, 2, 2 };
            int m = 6, n = 3;
            var lib = new MergeSortedArray();
            lib.Merge(nums1, m, nums2, n);
            CollectionAssert.AreEqual(new int[] { -1, 0, 0, 1, 2, 2, 3, 3, 3 }, nums1);

        }
        [TestMethod()]
        public void MergeTest2()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3, n = 3;
            var lib = new MergeSortedArray();
            lib.Merge(nums1, m, nums2, n);
            CollectionAssert.AreEqual(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
        }
    }
}