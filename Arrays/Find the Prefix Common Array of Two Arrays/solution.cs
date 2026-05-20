public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int n = A.Length;
        int[] retArr = new int[n];
        int len = 0;

        while(len != n){
            List<int> seen = new List<int>();
            int commonPrefix = 0;

            for(int i = 0; i <= len; i++){
                seen.Add(A[i]);
            }
            for(int j = 0; j <= len; j++){
                if(seen.Contains(B[j])) commonPrefix++;
            }
            retArr[len] = commonPrefix;
            len++; 
        }

        return retArr;
    }
}
