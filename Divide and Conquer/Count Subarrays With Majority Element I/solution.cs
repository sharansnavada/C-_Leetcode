public class Solution {
    public int CountMajoritySubarrays(int[] nums, int target) {
        int subArrays = 0;

        for(int i = 0; i < nums.Length; i++){
            int numOfTarget = 0;
            for(int j = i; j < nums.Length; j++){
                if(nums[j] == target) numOfTarget++;
                if(j - i == 0 && numOfTarget > 0) subArrays++;
                else if(numOfTarget > (j - i + 1 - numOfTarget)) subArrays++;
            }
        }
        return subArrays;
    }
}
