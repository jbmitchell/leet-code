using System.Collections;
using System.Collections.Specialized;
using System.Text;

namespace LeetCodeLibrary.Medium
{
    public class IntToRomanSolution
    {
        //https://leetcode.com/problems/integer-to-roman/description/
        //constraint: 1 <= num <= 3999
        // Symbol	Value
        // I	1
        // V	5
        // X	10
        // L	50
        // C	100
        // D	500
        // M	1000
        public string IntToRoman(int num)
        {
            var result = new StringBuilder(4);
            var list = new List<KeyValuePair<int, string>>
            {
                new(1000, "M"),
                new(900, "CM"),
                new(500, "D"),
                new(400, "CD"),
                new(100, "C"),
                new(90, "XC"),
                new(50, "L"),
                new(40, "XL"),
                new(10, "X"),
                new(9, "IX"),
                new(5, "V"),
                new(4, "IV"),
                new(1, "I"),
            };


            for (var i = 0; i < list.Count;)
            {
                var entry = list[i]!;
                var diff = num - entry.Key;
                if (diff >= 0)
                {
                    result.Append(entry.Value);
                    num = diff;
                }
                else
                {
                    i++;
                }
            }

            return result.ToString();
        }
    }
}
