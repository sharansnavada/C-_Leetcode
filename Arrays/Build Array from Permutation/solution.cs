public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] retArray = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            retArray[i] = nums[nums[i]];
        }
        return retArray;
    }
}
