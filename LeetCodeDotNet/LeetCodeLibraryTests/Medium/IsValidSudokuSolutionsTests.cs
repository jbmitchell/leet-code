using LeetCodeLibrary.Medium;

namespace LeetCodeLibraryTests.Medium
{
    [TestClass()]
    public class IsValidSudokuSolutionsTests
    {
        [TestMethod()]
        public void IsValidSudokuTest1()
        {
            var board = new[] {
                new[]{'5','3','.','.','7','.','.','.','.'},
                new[]{'6','.','.','1','9','5','.','.','.'},
                new[]{'.','9','8','.','.','.','.','6','.'},
                new[]{'8','.','.','.','6','.','.','.','3'},
                new[]{'4','.','.','8','.','3','.','.','1'},
                new[]{'7','.','.','.','2','.','.','.','6'},
                new[]{'.','6','.','.','.','.','2','8','.'},
                new[]{'.','.','.','4','1','9','.','.','5'},
                new[]{'.','.','.','.','8','.','.','7','9'}
            };
            //arrange
            var solution = new IsValidSudokuSolutions();
            //act
            var result = solution.IsValidSudoku(board);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod("Bad Col")]
        public void IsValidSudokuTest2()
        {
            var board = new[] {
                new[]{'8','3','.','.','7','.','.','.','.'},
                new[]{'6','.','.','1','9','5','.','.','.'},
                new[]{'.','9','8','.','.','.','.','6','.'},
                new[]{'8','.','.','.','6','.','.','.','3'},
                new[]{'4','.','.','8','.','3','.','.','1'},
                new[]{'7','.','.','.','2','.','.','.','6'},
                new[]{'.','6','.','.','.','.','2','8','.'},
                new[]{'.','.','.','4','1','9','.','.','5'},
                new[]{'.','.','.','.','8','.','.','7','9'}
            };
            //arrange
            var solution = new IsValidSudokuSolutions();
            //act
            var result = solution.IsValidSudoku(board);

            //assert
            Assert.AreEqual(false, result);
        }
        [TestMethod("Bad Row")]
        public void IsValidSudokuTest3()
        {
            var board = new[] {
                new[]{'5','3','.','.','7','.','.','.','.'},
                new[]{'6','.','.','1','9','5','.','.','.'},
                new[]{'.','9','8','.','.','.','.','6','.'},
                new[]{'8','.','.','.','6','.','.','.','3'},
                new[]{'4','.','.','8','.','3','.','.','1'},
                new[]{'7','.','.','.','2','.','.','.','6'},
                new[]{'.','6','.','.','.','.','2','8','.'},
                new[]{'.','.','.','4','1','9','.','.','5'},
                new[]{'9','.','.','.','8','.','.','7','9'}
            };
            //arrange
            var solution = new IsValidSudokuSolutions();
            //act
            var result = solution.IsValidSudoku(board);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod("Bad Sub Square")]
        public void IsValidSudokuTest4()
        {
            var board = new[] {
                new[]{'5','3','.','.','7','.','.','.','.'},
                new[]{'6','.','.','1','9','5','.','.','.'},
                new[]{'.','9','8','.','.','.','.','6','.'},
                new[]{'8','.','.','.','6','.','.','.','3'},
                new[]{'4','.','.','8','.','3','.','.','1'},
                new[]{'7','.','.','.','2','.','.','.','6'},
                new[]{'.','6','.','.','.','.','9','8','.'},
                new[]{'.','.','.','4','1','9','.','.','5'},
                new[]{'9','.','.','.','8','.','.','7','9'}
            };
            //arrange
            var solution = new IsValidSudokuSolutions();
            //act
            var result = solution.IsValidSudoku(board);

            //assert
            Assert.AreEqual(false, result);
        }
        [TestMethod("Bad Sub Square 2")]
        public void IsValidSudokuTest5()
        {
            var board = new[] {
                new[]{'.','4','.','.','.','.','.','.','.'},
                new[]{'.','.','4','.','.','.','.','.','.'},
                new[]{'.','.','.','1','.','.','7','.','.'},
                new[]{'.','.','.','.','.','.','.','.','.'},
                new[]{'.','.','.','3','.','.','.','6','.'},
                new[]{'.','.','.','.','.','6','.','9','.'},
                new[]{'.','.','.','.','1','.','.','.','.'},
                new[]{'.','.','.','.','.','.','2','.','.'},
                new[]{'.','.','.','8','.','.','.','.','.'}
            };
            //arrange
            var solution = new IsValidSudokuSolutions();
            //act
            var result = solution.IsValidSudoku(board);

            //assert
            Assert.AreEqual(false, result);
        }
    }
}