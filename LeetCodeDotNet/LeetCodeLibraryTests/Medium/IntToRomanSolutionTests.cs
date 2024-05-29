using LeetCodeLibrary.Medium;

namespace LeetCodeLibraryTests.Medium
{
    [TestClass]
    public class IntToRomanSolutionTests
    {
        [TestMethod]
        [DataRow(3749, "MMMDCCXLIX")]
        [DataRow(58, "LVIII")]
        [DataRow(1994, "MCMXCIV")]
        [DataRow(3999, "MMMCMXCIX")]
        [DataRow(49, "XLIX")]
        public void IntToRomanTest(int num, string expected)
        {
            //arrange
            var solution = new IntToRomanSolution();
            //act
            var result = solution.IntToRoman(num);
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}