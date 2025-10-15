using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Practise
{
    class matrix3x3maximumnumber
    {
        public int[][] LargestLocal(int[][] grid)
        {
            List<int> addList = new List<int>();
            int[][] largestLocal = new int[grid.Length - 2][];
            int row = 0, column = 0;
            for(int i = 0; i < grid.Length - 2; i++)
            {
                int[] arr1 = grid[i]; int[] arr2 = grid[i + 1]; int[] arr3 = grid[i + 2];
                int index = 0; int maxNumber = int.MinValue;
                while(index != 3/*arr1.Length - 2*/)
                {
                    for(int j = index; j < 3/*arr1.Length - 2*/; j++)
                    {
                        if (arr1[j] > maxNumber)
                            maxNumber = arr1[j];
                        if (arr2[j] > maxNumber)
                            maxNumber = arr2[j];
                        if (arr3[j] > maxNumber)
                            maxNumber = arr3[j];
                    }

                    addList.Add(maxNumber);
                    column++;
                    
                    if(column == grid.Length - 2)
                    {
                        largestLocal[row] = addList.ToArray();
                        addList = new List<int>();
                        row++; column = 0;
                    }

                    index++;
                }
            }

            return largestLocal;
        }
    }
}



using System;
using System.Collections.Generic;
namespace CSharp_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            matrix3x3maximumnumber q33 = new matrix3x3maximumnumber();
            int[][] mat = q33.LargestLocal(new int[][]{ new int[] { 9, 9, 8, 1 }, new int[] { 5, 6, 2, 6 }, new int[] { 8, 2, 6, 4 }, new int[] { 6, 2, 2, 2 } });
        }
    }
}
