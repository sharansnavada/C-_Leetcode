public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] retArr = new int[2 * n];
        int index = 0;

        for(int i = 0; i < n; i++){
            retArr[index] = nums[i];
            retArr[index + 1] = nums[i + n];
            index = index + 2;
        }

        return retArr;
    }
}
