public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int gridLength = grid.Length;
        int[] hashTable = new int[gridLength * gridLength];
        int repeated = 0, missing = 0;

        foreach(int[] array in grid){
            foreach(int number in array){
                hashTable[number - 1]++; //as I am using hashtable, so has to match with the index of hashtable I am subtracting with 1.
            }
        }
        for(int i = 0; i < gridLength * gridLength; i++){
            if(hashTable[i] == 2)
                repeated = i + 1;
            if(hashTable[i] == 0)
                missing = i + 1;
        }

        return new int[]{repeated, missing};
    }
}
