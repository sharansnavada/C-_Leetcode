public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        while(k > 0){
            int minValue = int.MaxValue;
            int index = 0;
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] < minValue){
                    minValue = nums[i];
                    index = i;
                }
            }
            nums[index] = nums[index] * multiplier;
            k--;
        }
        return nums;
    }
}