public class Solution {
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k) {
        //int[][] flipGrid = grid;
        int[][] flipGrid = new int[grid.Length][];
        int flipLeftOver = k * k;
        

        for(int i = 0; i < grid.Length; i++)
        {
            int[] arr = new int[grid[i].Length];
            for(int j = 0; j < grid[i].Length; j++)
            {
                arr[j] = grid[i][j];
            }
            flipGrid[i] = arr;
        }
        
        int flipIndex = x + k - 1;
        bool flipped = false;

        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(i >= x && i < (i + k) && j >= y && j < (y + k) && flipLeftOver != 0)
                {
                    flipGrid[flipIndex][j] = grid[i][j];
                    flipped = true;
                    flipLeftOver--;
                }
            }
            if (flipped)
            {
                flipIndex--;
                flipped = false;
            }
        }

        return flipGrid;
    }
}
