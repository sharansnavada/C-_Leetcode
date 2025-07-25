public class Solution {
    public bool IsGood(int[] nums) {
        Array.Sort(nums);
        int baseNum = nums[nums.Length - 1];
        if (nums.Length != (baseNum + 1)) // array size should be equal to larger array element plus one.
            return false;
        for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != (i + 1))
                    return false;
            }
        if (nums[nums.Length - 1] == baseNum) //check last both 2 elements should be the array's larger element.
            return true;
        return false;
    }
}
