public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] retArr = new int[nums.Length * 2];

        for(int i = 0; i < nums.Length; i++){
            retArr[i] = nums[i];
            retArr[i + nums.Length] = nums[i];
        }
        return retArr;
    }
}
