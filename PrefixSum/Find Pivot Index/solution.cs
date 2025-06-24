public class Solution {
    public int PivotIndex(int[] nums) {
        for(int index = 0; index < nums.Length; index++){
            int leftSum = 0;int rightSum = 0;
            for(int leftIndex = index - 1; leftIndex >= 0; leftIndex--){
                leftSum += nums[leftIndex];
            }
            for(int rightIndex = index + 1; rightIndex < nums.Length; rightIndex++){
                rightSum += nums[rightIndex];
            }
            if(leftSum == rightSum){
                return index;
            }
        }
        return -1;
    }
}
