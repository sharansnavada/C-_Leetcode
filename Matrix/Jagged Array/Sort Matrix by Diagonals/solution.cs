public class Solution {
    public int[][] SortMatrix(int[][] grid) {
        int[][] retGrid = new int[grid.Length][];
      
        for(int i = 0; i < grid.Length; i++)
        {
            retGrid[i] = new int[grid[0].Length];
        }
      
        int row = grid.Length - 1;
        int col = 0;
        int elementsCount = 0;
        bool bottomTriangle = true;

        while(elementsCount != (grid.Length * grid.Length))
        {
            int loopCount = 0;
            List<int> ls = new List<int>();
            while(loopCount != 3)
            {
                int tempRow = row;
                int tempCol = col;
                if(loopCount == 0)
                {
                    while(tempRow < grid.Length && tempCol < grid.Length)
                    {
                        ls.Add(grid[tempRow++][tempCol++]);
                    }
                    if (bottomTriangle)
                        ls = ls.OrderByDescending(n => n).ToList();
                    else
                        ls.Sort();
                    tempRow = row;
                    tempCol = col;
                    loopCount++;
                }
                else if(loopCount == 1)
                {
                    int index = 0;
                    while(tempRow < grid.Length && tempCol < grid.Length)
                    {
                        retGrid[tempRow++][tempCol++] = ls[index++];
                        elementsCount++;
                    }
                    loopCount++;
                }
                else
                {
                    int[] newRowColData = GetRowAndCol(row, col);
                    row = newRowColData[0];
                    col = newRowColData[1];
                    if(col > row) bottomTriangle = false;
                    loopCount++;
                }
            }
        }

        return retGrid;
    }
    
    public int[] GetRowAndCol(int row, int col)
    {
        if(row > col)
            return new int[]{--row, col};
        else
            return new int[]{row, ++col};
    }
}
