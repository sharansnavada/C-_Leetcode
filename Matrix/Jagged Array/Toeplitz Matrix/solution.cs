//In this code, I am checking the diagonal elemnts for each row even if those diagonal
//elemsts are checked in the previous row.
//I can optimize the code so that if we have already checked the diagonals, 
//we will not check again when we go to the next row.

//Time Complexity ---> O(Rows∗Columns)
//Space Complexity --> O(1)

public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        int i = 0; int j = 0;
        while (i < matrix.Length)
        {
            int similarNumber = matrix[i][j];
            int tempI = i; int tempJ = j;
            while (i < matrix.Length)
            {
                if (j < matrix[i].Length)
                {
                    if (matrix[i][j] == similarNumber)
                    {
                        i++; j++;
                    }
                    else { return false; }
                }
                else
                {
                    i++;  //added this to exit from current while loop.
                }
            }
            i = tempI; j = tempJ;
            if (j >= matrix[i].Length - 1) //if if we have checked for the last element of that particular row, move to next row first column
            {
                i++; j = 0;
            }
            else
            {
                j++; //else just move for nect column/element
            }
        }
        return true;
    }
}
