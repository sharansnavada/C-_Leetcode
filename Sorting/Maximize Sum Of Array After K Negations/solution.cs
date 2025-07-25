public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        int sum = 0;
        while(k != 0){
            int smallest = int.MaxValue; int index = 0; sum = 0;
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] < smallest){
                    smallest = nums[i];
                    index = i; //to change the smallest index value to multiply with -1.
                }    
                sum += nums[i];
            }
            sum -= nums[index]; // to alter the sum with negation of smallest element of the array.
            nums[index] *= -1; 
            sum += nums[index];
            k--;
        }
        return sum;
    }
}
