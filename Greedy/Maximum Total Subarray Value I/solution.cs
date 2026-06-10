public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        Array.Sort(nums);
        return (long)k * (nums[nums.Length - 1] - nums[0]);
    }
}
