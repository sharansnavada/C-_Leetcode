public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] count = new int[nums.Length];
        int arrIndex = 0;
        for(int i = 0; i < nums.Length; i++){
            int currentNumber = nums[i]; int smallerCount = 0;
            for(int j = 0; j < nums.Length; j++){
                if(currentNumber > nums[j]) smallerCount++;
            }
            count[arrIndex++] = smallerCount;
        }
        return count;
    }
}
