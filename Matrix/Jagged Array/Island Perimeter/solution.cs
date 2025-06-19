public class Solution {
    public int IslandPerimeter(int[][] grid) {
         int finalPerimeter = 0;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        int notPerimeterSides = CheckForTheSurrondings(grid,i,j);
                        finalPerimeter = finalPerimeter + 4 - notPerimeterSides;
                    }
                }
            }

            return finalPerimeter;
    }

    public int CheckForTheSurrondings(int[][] grid, int i, int j)
        {
            int notPerimeterSides = 0;
            int upperRow = i - 1;
            int lowerRow = i + 1;
            int leftColumn = j - 1;
            int rightColumn = j + 1;

            if(upperRow >= 0 && upperRow < grid.Length && grid[upperRow][j] == 1)
            {
                notPerimeterSides++;
            }

            if (lowerRow >= 0 && lowerRow < grid.Length && grid[lowerRow][j] == 1)
            {
                notPerimeterSides++;
            }

            if (leftColumn >= 0 && leftColumn < grid[i].Length && grid[i][leftColumn] == 1)
            {
                notPerimeterSides++;
            }

            if (rightColumn >= 0 && rightColumn < grid[i].Length && grid[i][rightColumn] == 1)
            {
                notPerimeterSides++;
            }

            return notPerimeterSides;

        }
}
