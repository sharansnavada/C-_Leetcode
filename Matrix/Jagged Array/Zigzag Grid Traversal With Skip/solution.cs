using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Practise
{
        public class zigzag
    {
        public IList<int> ZigzagTraversal(int[][] grid)
        {
            bool isEvenRow = true;
            List<int> retList = new List<int>();
            int column = 0;
            bool lastElementInPrevRow = !(grid[0].Length % 2 == 0);

            for (int row = 0; row < grid.Length; row++)
            {
                if (isEvenRow)
                {
                    int[] arr = grid[row];
                    while (column < grid[row].Length)
                    {
                        retList.Add(arr[column]);
                        column += 2;
                    }
                    isEvenRow = !isEvenRow;
                }
                else
                {
                    if (lastElementInPrevRow)
                    {
                        column = grid[row].Length - 2;
                    }
                    else
                    {
                        column = grid[row].Length - 1;
                    }

                    int[] arr = grid[row];

                    while (column >= 0)
                    {
                        retList.Add(arr[column]);
                        column -= 2;
                    }

                    isEvenRow = !isEvenRow;
                }
            }
            return retList;
        }
    }
}

