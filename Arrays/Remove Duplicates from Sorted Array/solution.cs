public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int start = 0;
        int end = 1;
        int count = 0;

        while(end != nums.Length){
            if(nums[start] == nums[end]){
                end++;
            }
            else{
                nums[start + 1] = nums[end];
                start++;end++;
                count++;
            }
        }
        return count + 1;
    }
}
