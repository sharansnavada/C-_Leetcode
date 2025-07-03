public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> result = new List<int>();

    for (int i = 0; i < nums.Length; i++) {
        int index = Math.Abs(nums[i]) - 1;

        if (nums[index] < 0) {
            result.Add(index + 1);  // Already visited → duplicate
        } else {
            nums[index] = -nums[index];  // Mark as visited
        }
    }

    return result;
    }
}
