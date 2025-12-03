public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int[] retArr = new int[2];
        int maxOneCount = 0;

        for(int i = 0; i < mat.Length; i++){
            int currentMaxOnes = 0;
            for(int j = 0; j < mat[i].Length; j++){
                if(mat[i][j] == 1) currentMaxOnes++;
            }
            if(currentMaxOnes > maxOneCount){
                maxOneCount = currentMaxOnes;
                retArr[0] = i;
                retArr[1] = currentMaxOnes;
            }
        }
        return retArr;
    }
}
