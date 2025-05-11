public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        bool hasOddConsecutive = false;
         
         if(arr.Length >= 3){
            for(int i = 0; i < arr.Length - 2; i++){
                hasOddConsecutive = has3Consecutive(arr[i],arr[i+1],arr[i+2]);
                if(hasOddConsecutive){
                    return true;
                }
            }
         }
         return hasOddConsecutive;
    }

    public bool has3Consecutive(int i, int j, int k){
        int[] arr = new int[3]{i,j,k};
        foreach(int num in arr){
            if((num % 2) == 0){
                return false;
            }
        }
        return true;
    }
}
