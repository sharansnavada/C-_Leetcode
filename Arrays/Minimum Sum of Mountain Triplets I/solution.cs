public class Solution {
    public int MinimumSum(int[] nums) {
        int minSum = int.MaxValue;
        bool found = false; 

        for(int i = 0; i <= nums.Length - 3; i++){
            for(int j = i + 1; j <= nums.Length - 2; j++){
                for(int k = j + 1; k <= nums.Length - 1; k++){
                    if ((nums[i] < nums[j]) && nums[k] < nums[j])
                    {
                        if (nums[i] + nums[j] + nums[k] < minSum)
                        {
                            minSum = nums[i] + nums[j] + nums[k];
                            found = true;
                        }
                    }
                }
            }
        }
        if(found)
            return minSum;
        else
            return -1;
    }
}
