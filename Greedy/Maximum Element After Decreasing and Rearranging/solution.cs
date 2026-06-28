public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        arr.Sort();
        int n = 1;
        arr[0] = 1;
 
        for(int i = 1; i < arr.Length; i++){
            int num = arr[i] - arr[i - 1];
            if(num != 0)
             arr[i] = arr[i] - num + 1;
            n = arr[i] > n ? arr[i] : n;
        }
        return n;
    }
}