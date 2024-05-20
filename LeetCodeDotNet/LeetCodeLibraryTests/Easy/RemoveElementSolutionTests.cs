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
        [DataRow(new []{ 3, 2, 2, 3 }, 3, new [] { 2, 2 })]
        [DataRow(new []{ 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new [] { 0, 1, 4, 0, 3 })]
        public void RemoveElementTest(int[] nums, int val, int[] expectedNums)
        {
            RemoveElementHelper(nums, val, expectedNums);
        }

        private void RemoveElementHelper(int[] nums, int val, int[] expectedNums)
        {
            //arrange
            var sol = new RemoveElementSolution();
            //act
            var k = sol.RemoveElement(nums, val);
            //assert
            Assert.AreEqual(expectedNums.Length, k);
            CollectionAssert.AreEquivalent(expectedNums, nums.Take(expectedNums.Length).ToArray());
        }
    }
}