public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);

        for(int i = 0; i <= nums.Length -1; i++){
            if(i != nums[i]){
                return i;
            }
        }
        return nums[nums.Length -1] + 1;
    }
}
