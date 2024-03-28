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
    public class RemoveElementSolutionTests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            int[] nums = { 3, 2, 2, 3 };
            var val = 3;
            int[] expectedNums = { 2, 2 };
            RemoveElementHelper(nums, val, expectedNums);
        }

        [TestMethod()]
        public void RemoveElementTest2()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            var val = 2;
            int[] expectedNums = { 0, 1, 4, 0, 3 };
            RemoveElementHelper(nums, val, expectedNums);
        }

        private void RemoveElementHelper(int[] nums, int val, int[] expectedNums)
        {
            var sol = new RemoveElementSolution();
            var k = sol.RemoveElement(nums, val);
            Assert.AreEqual(expectedNums.Length, k);
            CollectionAssert.AreEquivalent(expectedNums, nums.Take(expectedNums.Length).ToArray());
        }
    }
}