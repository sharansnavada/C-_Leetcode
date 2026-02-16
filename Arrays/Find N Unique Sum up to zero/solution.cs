public class Solution {
    public int[] SumZero(int n) {
        int[] retArr = new int[n];
        int uniqueInteger = 1;
        bool positive = true;

        for(int i = 0; i < n; i++){
            retArr[i] = uniqueInteger;
            if(positive){
                uniqueInteger = -(uniqueInteger);
                positive = !positive; 
            } 
            else{
                uniqueInteger = (-(uniqueInteger)) + 1;
                positive = !positive;
            }
        }

        if(n % 2 != 0){
            retArr[n - 1] = 0;
        } 

        return retArr;
    }
}
