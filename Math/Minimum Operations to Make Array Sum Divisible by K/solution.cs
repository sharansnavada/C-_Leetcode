public class Solution {
    public int MinOperations(int[] nums, int k) {
        int sum = nums.Sum();
        int count = 0;

            while(sum % k != 0){
                sum -= 1;
                count++;
            }

        return count;
    }
}
