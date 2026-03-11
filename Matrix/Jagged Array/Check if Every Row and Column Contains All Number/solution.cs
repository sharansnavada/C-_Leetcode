public class Solution {
    public bool CheckValid(int[][] matrix) {
        int[] hashTable = new int[matrix.Length];

        // checking each row.
        foreach(int[] arr in matrix){
            foreach(int num in arr){
                hashTable[num - 1]++;
            }
            foreach(int n in hashTable){
                if(n == 0) return false;
            }
            hashTable = new int[matrix.Length];
        }

        // checking each column.
        for(int i = 0; i < matrix.Length; i++){
            for(int j = 0; j < matrix.Length; j++){
                hashTable[matrix[j][i] - 1]++;
            }
            foreach(int n in hashTable){
                if(n == 0) return false;
            }
            hashTable = new int[matrix.Length];
        }

        return true;
    }
}
