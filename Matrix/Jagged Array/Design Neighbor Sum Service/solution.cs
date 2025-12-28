public class NeighborSum {

    int[][] matrix;
    int n = 0;
    
    public NeighborSum(int[][] grid) {
        matrix = grid;
        n = grid[0].Length;
    }
    
    public int AdjacentSum(int value) {
        int[] indexData = ReturnIndexOfValue(value);
        int i = indexData[0];
        int j = indexData[1];

        return CalculateAdjacentSum(i, j);
    }
    
    public int DiagonalSum(int value) {
        int[] indexData = ReturnIndexOfValue(value);
        int i = indexData[0];
        int j = indexData[1];

        return CalculateDiagonalSum(i, j);
    }

    public int[] ReturnIndexOfValue(int value)
    {
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                if(matrix[i][j] == value)
                    return new int[]{i, j};
            }
        }
        return new int[]{-1, -1};
    }

    public int CalculateAdjacentSum(int i, int j)
    {
        int sum = 0;

        if((i - 1) >= 0 && ((i - 1) < n))
        {
            sum += matrix[i - 1][j];
        }
        if((i + 1) >= 0 && (i + 1) < n)
        {
            sum += matrix[i + 1][j];
        }
        if((j - 1) >= 0 && (j - 1) < n)
        {
            sum += matrix[i][j - 1];
        }
        if((j + 1) >= 0 && (j + 1) < n)
        {
            sum += matrix[i][j + 1];
        }

        return sum;
    }

    public int CalculateDiagonalSum(int i, int j)
    {
        int sum = 0;

        if((i - 1) >= 0 && (i - 1) < n && (j - 1) >= 0 && (j - 1) < n)
            sum += matrix[i - 1][j - 1];
        if((i - 1) >= 0 && (i - 1) < n && (j + 1) >= 0 && (j + 1) < n)
            sum += matrix[i - 1][j + 1];
        if((i + 1) >= 0 && (i + 1) < n && (j - 1) >= 0 && (j - 1) < n)
            sum += matrix[i + 1][j - 1];
        if((i + 1) >= 0 && (i + 1) < n && (j + 1) >= 0 && (j + 1) < n)
            sum += matrix[i + 1][j + 1];
        
        return sum;
    }
}

/**
 * Your NeighborSum object will be instantiated and called as such:
 * NeighborSum obj = new NeighborSum(grid);
 * int param_1 = obj.AdjacentSum(value);
 * int param_2 = obj.DiagonalSum(value);
 */
