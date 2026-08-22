public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        int maxSequence = 1;
        int currentMaxSequence = 1;
        int prevNumber = nums[0];

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > prevNumber){
                currentMaxSequence++;
            }
            else{
                maxSequence = currentMaxSequence > maxSequence ? currentMaxSequence : maxSequence;
                currentMaxSequence = 1;
            }
            prevNumber = nums[i];
        }
        maxSequence = currentMaxSequence > maxSequence ? currentMaxSequence : maxSequence;
        return maxSequence;
    }
}
