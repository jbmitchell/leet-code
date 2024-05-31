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

        public bool IsValidSudokuTakeTwo(char[][] board)
        {
            var foundCol = new HashSet<int>();
            var foundSub1 = new HashSet<int>();
            var foundSub2 = new HashSet<int>();
            var foundSub3 = new HashSet<int>();
            var foundSub4 = new HashSet<int>();
            var foundSub5 = new HashSet<int>();
            var foundSub6 = new HashSet<int>();
            var foundSub7 = new HashSet<int>();
            var foundSub8 = new HashSet<int>();
            var foundSub9 = new HashSet<int>();

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
                    if (foundCol.Contains((j * 100) + cell)) return false;
                    foundCol.Add((j * 100) + cell);
                    switch (i)
                    {
                        //top left
                        case >= 0 and < 3 when j is >= 0 and < 3:
                        {
                            if (foundSub1.Contains(cell)) return false;
                            foundSub1.Add(cell);
                            break;
                        }
                        //top middle
                        case >= 0 and < 3 when j is >= 3 and < 6:
                        {
                            if (foundSub2.Contains(cell)) return false;
                            foundSub2.Add(cell);
                            break;
                        }
                        //top right
                        case >= 0 and < 3 when j is >= 6 and < 9:
                        {
                            if (foundSub3.Contains(cell)) return false;
                            foundSub3.Add(cell);
                            break;
                        }
                        //middle left
                        case >= 3 and < 6 when j is >= 0 and < 3:
                        {
                            if (foundSub4.Contains(cell)) return false;
                            foundSub4.Add(cell);
                            break;
                        }
                        //middle middle
                        case >= 3 and < 6 when j is >= 3 and < 6:
                        {
                            if (foundSub5.Contains(cell)) return false;
                            foundSub5.Add(cell);
                            break;
                        }
                        //middle right
                        case >= 3 and < 6 when j is >= 6 and < 9:
                        {
                            if (foundSub6.Contains(cell)) return false;
                            foundSub6.Add(cell);
                            break;
                        }
                        //bottom left
                        case >= 6 and < 9 when j is >= 0 and < 3:
                        {
                            if (foundSub7.Contains(cell)) return false;
                            foundSub7.Add(cell);
                            break;
                        }
                        //bottom middle
                        case >= 6 and < 9 when j is >= 3 and < 6:
                        {
                            if (foundSub8.Contains(cell)) return false;
                            foundSub8.Add(cell);
                            break;
                        }
                        //bottom right
                        case >= 6 and < 9 when j is >= 6 and < 9:
                        {
                            if (foundSub9.Contains(cell)) return false;
                            foundSub9.Add(cell);
                            break;
                        }
                    }
                    j++;
                }
                i++;
            }

            return true;
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
