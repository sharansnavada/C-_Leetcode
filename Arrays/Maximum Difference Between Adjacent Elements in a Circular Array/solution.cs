public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int maxDifference = 0;
 
        for(int i = 0; i < nums.Length - 1; i++){
            if(Math.Abs(nums[i] - nums[i + 1]) > maxDifference){
                maxDifference = Math.Abs(nums[i] - nums[i + 1]);
            }
        }
 
        if(Math.Abs(nums[0] - nums[nums.Length - 1]) > maxDifference)
            maxDifference = Math.Abs(nums[0] - nums[nums.Length - 1]);
       
        return maxDifference;
    }
}