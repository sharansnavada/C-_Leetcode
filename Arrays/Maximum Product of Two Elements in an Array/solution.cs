public class Solution {
    public int MaxProduct(int[] nums) {
        int firstMax = int.MinValue;
        int secondMax = int.MinValue;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > firstMax){
                secondMax = firstMax;
                firstMax = nums[i];
            }
            else if(nums[i] > secondMax){
                secondMax = nums[i];
            }
        }

        return (firstMax - 1) * (secondMax - 1);
    }
}
