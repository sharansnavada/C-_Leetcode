public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int count = 0;
        int sum = 0;

        foreach(int number in nums){
            sum += number;
            count = sum == 0 ? count + 1 : count;
        }

        return count;
    }
}
