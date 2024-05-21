using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LeetCodeLibrary.Medium
{
    /*
2. Add Two Numbers
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:


Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
     */
    public class AddTwoNumbersSolution
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var output = AddTwoNumbers(l1, l2, 0)!;
            return output;
        }

        private static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0) return null;
            var v1 = l1?.val ?? 0; 
            var v2 = l2?.val ?? 0;
            v1 += carry;
            var sum = v1 + v2;
            var newCarry = 0;
            int? digit;
            if (sum >= 10)
            {
                digit = sum % 10;
                newCarry = (sum - (sum % 10)) / 10;
            }
            else
            {
                digit = sum;
            }

            return digit is null
                ? null
                : new ListNode((int)digit, AddTwoNumbers(l1?.next, l2?.next, newCarry));
        }
        public ListNode AddTwoNumbersSlow(ListNode l1, ListNode l2)
        {
            var l1Sb = ConvertListNodeToStringBuilder(l1);
            var l2Sb = ConvertListNodeToStringBuilder(l2);
            //reverse string, convert to bigInt for both, then add
            var l1BigInt =  BigInteger.Parse(new string(l1Sb.ToString().Reverse().ToArray()));
            var l2BigInt =  BigInteger.Parse(new string(l2Sb.ToString().Reverse().ToArray()));
            var sumBigInt = l1BigInt + l2BigInt;
            var reversed = new string(sumBigInt.ToString().Reverse().ToArray());
            return ConvertFromStringToListNode(reversed ?? "");
        }

        private static StringBuilder ConvertListNodeToStringBuilder(ListNode input)
        {
                var output = new StringBuilder();
                while (input.next != null)
                {
                    output.Append(input.val);
                    input = input.next;
                }
                output.Append(input.val);
                return output;
        }
        private static ListNode ConvertFromStringToListNode(string input)
        {
            var reference = new ListNode((int)char.GetNumericValue(input[0]));
            var output = reference;

            for (var index = 1; index < input.Length; index++)
            {
                var inputChar = input[index];
                var current = new ListNode((int)char.GetNumericValue(inputChar));
                reference.next = current;
                reference = current;
            }

            return output;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
