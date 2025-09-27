public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);
        List<int> appendList = new List<int>();

        for (int i = 0; i < nums.Length; i = i + 2)
        {
            appendList.Add(nums[i + 1]);
            appendList.Add(nums[i]);
        }

        return appendList.ToArray();
    }
}
