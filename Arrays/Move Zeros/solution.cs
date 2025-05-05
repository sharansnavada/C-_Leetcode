public class Solution {
    public void MoveZeroes(int[] nums) {
        int insertPos = 0;

        // Move non-zero elements forward
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[insertPos++] = nums[i];
            }
        }

        // Fill the remaining positions with 0
        for (int i = insertPos; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}
