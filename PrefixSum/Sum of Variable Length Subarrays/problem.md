public class Solution {
    public int SubarraySum(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            int start = (i - nums[i]) > 0 ? (i - nums[i]) : 0;
            for(int j = start; j <= i; j++){
                sum += nums[j];
            }
        }
        return sum;
    }
}
