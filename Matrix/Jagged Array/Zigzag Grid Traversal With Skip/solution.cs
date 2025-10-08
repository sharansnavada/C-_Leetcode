public class Solution {
    public IList<int> ZigzagTraversal(int[][] grid) {
        int row = grid.Length - 1;
        int column = grid[row].Length - 1;
        int i = 0; int j = 0;
        List<int> retList = new List<int>();

        if (column + 1 == 2)
        {
            bool evenRow = true;
            while (i < row + 1 && j < column + 1)
            {
                if (evenRow)
                    retList.Add(grid[i++][j++]);
                else
                    retList.Add(grid[i++][j--]);

                evenRow = !evenRow;
            }
        }
        else
        {
            retList.Add(grid[i][j]);
            j = column;
            while (i < row + 1 && j < column + 1)
            {
                retList.Add(grid[i++][j--]);
            }
            i--;
            if(row + 1 != 2) // if only two rowa are there no need to add the last row last colmns element. [[1,9,9],[6,2,8]]
                retList.Add(grid[i][column]);
        }

        return retList;
    }
}
