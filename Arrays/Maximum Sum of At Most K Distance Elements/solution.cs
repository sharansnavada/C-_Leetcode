public class Solution {
    public int[] MaxKDistinct(int[] nums, int k) {
        HashSet<int> set = new HashSet<int>();

        // get unique values
        for (int i = 0; i < nums.Length; i++) {
            set.Add(nums[i]);
        }

        // convert to list and sort descending
        List<int> list = new List<int>(set);
        list.Sort((a, b) => b - a);

        int size = Math.Min(k, list.Count);
        int[] result = new int[size];

        for (int i = 0; i < size; i++) {
            result[i] = list[i];
        }

        return result;
    }
}
