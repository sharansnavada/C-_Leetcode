using System;

public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);  // Step 1: Sort the array
        long count = 0;
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            int left = LowerBound(nums, i + 1, n - 1, lower - nums[i]);
            int right = UpperBound(nums, i + 1, n - 1, upper - nums[i]);
            count += (right - left);
        }

        return count;
    }

    // Finds the first index where nums[index] >= target
    private int LowerBound(int[] nums, int start, int end, int target) {
        while (start <= end) {
            int mid = start + (end - start) / 2;
            if (nums[mid] >= target) end = mid - 1;
            else start = mid + 1;
        }
        return start;
    }

    // Finds the first index where nums[index] > target
    private int UpperBound(int[] nums, int start, int end, int target) {
        while (start <= end) {
            int mid = start + (end - start) / 2;
            if (nums[mid] > target) end = mid - 1;
            else start = mid + 1;
        }
        return start;
    }
}
