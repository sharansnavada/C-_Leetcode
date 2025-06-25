public class Solution {
    public int Search(int[] nums, int target) {
        int high = nums.Length - 1;
        int low = 0;

        while(high >= low){
            int mid = low + (high - low) / 2;

            if(nums[mid] == target){
                return mid;
            }
            else if(nums[mid] < target){
                low = mid + 1;
            }

            else if(nums[mid] > target){
                high = mid - 1;
            }
        }
        return -1;
    }
}
