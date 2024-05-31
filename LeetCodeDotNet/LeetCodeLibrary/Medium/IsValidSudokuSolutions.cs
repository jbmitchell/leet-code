using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Medium
{
    public class IsValidSudokuSolutions
    {
        //https://leetcode.com/problems/valid-sudoku/description/
        //board.length == 9
        //board[i].length == 9
        //board[i][j] is a digit 1-9 or '.'.
        public bool IsValidSudoku(char[][] board)
        {
            //check rows
            var i = 0;
            while (i < 9)
            {
                var foundRow = new HashSet<int>();
                var j = 0;
                while (j < 9)
                {
                    var cell = (int)char.GetNumericValue(board[i][j]);
                    if (cell == -1)
                    {
                        j++;
                        continue;
                    }
                    if (foundRow.Contains(cell)) return false;
                    foundRow.Add(cell);
                    j++;
                }
                i++;
            }

            //check cols
            i = 0;
            while (i < 9)
            {
                var foundCol = new HashSet<int>();
                var j = 0;
                while (j < 9)
                {
                    var cell = (int)char.GetNumericValue(board[j][i]);
                    if (cell == -1)
                    {
                        j++;
                        continue;
                    }
                    if (foundCol.Contains(cell)) return false;
                    foundCol.Add(cell);
                    j++;
                }
                i++;
            }
            var result = CheckSubSquare(0, 0, board);
            if (!result) return false;
            result = CheckSubSquare(0, 3, board);
            if (!result) return false;
            result = CheckSubSquare(0, 6, board);
            if (!result) return false;
            result = CheckSubSquare(3, 0, board);
            if (!result) return false;
            result = CheckSubSquare(3, 3, board);
            if (!result) return false;
            result = CheckSubSquare(3, 6, board);
            if (!result) return false;
            result = CheckSubSquare(6, 0, board);
            if (!result) return false;
            result = CheckSubSquare(6, 3, board);
            if (!result) return false;
            result = CheckSubSquare(6, 6, board);
            return result;
        }

        private static bool CheckSubSquare(int startY, int startX, char[][] board)
        {
            var found = new HashSet<int>();
            var i = startY;
            while (i < startY + 3)
            {
                var j = startX;
                while (j < startX + 3)
                {
                    var cell = (int)char.GetNumericValue(board[i][j]);
                    if (cell == -1)
                    {
                        j++;
                        continue;
                    }
                    if (found.Contains(cell)) return false;
                    found.Add(cell);
                    j++;
                }
                i++;
            }

            return true;
        }
    }
}
