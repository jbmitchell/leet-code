using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeLibrary.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Medium.Tests
{
    [TestClass()]
    public class AddTwoNumbersSolutionTests
    {
        [TestMethod()]
        [DataRow(new[]{2,4,3}, new[]{5,6,4}, new[] {7,0,8})]
        [DataRow(new[]{0}, new[]{0}, new[]{0})]
        [DataRow(new[]{9,9,9,9,9,9,9}, new[]{9,9,9,9}, new[]{8,9,9,9,0,0,0,1})]
        [DataRow(new[]{5,6}, new[]{5,4,9}, new[]{0,1,0,1})]
        public void AddTwoNumbersTest(int[] l1, int[] l2, int[] expected)
        {
            //arrange
            var l1Node = ConvertFromIntArrayToListNode(l1);
            var l2Node = ConvertFromIntArrayToListNode(l2);
            var solution =  new AddTwoNumbersSolution();
            //act
            var result = solution.AddTwoNumbers(l1Node, l2Node);
            //assert
            var resultArray = ConvertFromListNodeToArray(result);
            CollectionAssert.AreEqual(expected, resultArray);
        }

        private static ListNode ConvertFromIntArrayToListNode(int[] input)
        {
            var reference = new ListNode(input[0]);
            var returnValue = reference;

            for (var index = 1; index < input.Length; index++)
            {
                var i = input[index];
                var current = new ListNode(i);
                reference.next = current;
                reference = current;
            }

            return returnValue;
        }

        private static int[] ConvertFromListNodeToArray(ListNode input)
        {
            var output = new List<int>();

            while (input.next != null)
            {
                output.Add(input.val);
                input = input.next;
            }
            output.Add(input.val);

            return output.ToArray();
        }
    }
}