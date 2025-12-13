public class Solution {
    public bool SatisfiesConditions(int[][] grid) {
        int n = grid[0].Length;
        int internalIndex = 0;
        int memberChecked = 0;

        while(memberChecked < n)
        {
            int number = grid[0][internalIndex];
            for(int i = 0; i < grid.Length; i++)
            {
                int[] arr = grid[i];
                if(internalIndex < (n - 1))
                {
                    if(arr[internalIndex] == arr[internalIndex + 1])
                        return false;
                }
                if(arr[internalIndex] != number)
                    return false;
            }
            memberChecked++;
            internalIndex++;
        }
        return true;
    }
}
