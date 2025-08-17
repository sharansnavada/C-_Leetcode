public class Solution {
    public int CountPartitions(int[] nums) {
        int arrSum = nums.Sum();
        int leftPointer = 0;
        int leftSum = 0;
        int rightSum = 0;
        int evenCount = 0;
        int arrSize = nums.Length;

        while(arrSize != 1){
            leftSum = 0;
            for(int i = 0; i <= leftPointer; i++){
                leftSum += nums[i];
            }
            rightSum = arrSum - leftSum;
            leftPointer++;
            arrSize--;
            if((leftSum - rightSum) % 2 == 0)
                evenCount++;

        }
        return evenCount;
    }
}
