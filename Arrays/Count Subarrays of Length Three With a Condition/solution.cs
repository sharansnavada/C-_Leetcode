public class Solution {
    public int CountSubarrays(int[] nums) {
        int count = 0;

        for(int i = 0; i < nums.Length - 2; i++){
            float num1 = nums[i] + nums[i + 2];
            float num2 = (float)nums[i+1]/2f;
            if(num1 == num2){
                count++;
            }
        }
        return count;
    }
}
