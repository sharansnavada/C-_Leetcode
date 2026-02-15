public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        int m = grid.Length;
        int n = grid[0].Length;

        while(k != 0){
            int prev = grid[m - 1][n - 1];
            int current = 0;

            for(int i = 0; i < m; i++){
                for(int j = 0; j < n; j++){
                    current = grid[i][j];
                    grid[i][j] = prev;
                    prev = current;
                }
            }
            k--;
        }
        return grid;
    }
}
