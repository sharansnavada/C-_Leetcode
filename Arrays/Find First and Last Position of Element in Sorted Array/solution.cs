public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] retArr = new int[]{-1, -1};
        if(nums.Length == 0) return retArr;
        else if(nums.Length == 1 && nums[0] == target) return new int[]{0, 0};
        int startIndex = -1;
        int endIndex = -1;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == target){
                if(startIndex == -1) startIndex = i;
                else endIndex = i;
            }
        }
        retArr[0] = startIndex; retArr[1] = endIndex != -1 ? endIndex : startIndex;
        return retArr;
    }
}
