public class Solution {
    public int[] NumberOfPairs(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            int number = nums[i];
            for(int j = i + 1; j < nums.Length; j++){
                if(number == nums[j] && number != -1){
                    nums[i] = -1; nums[j] = -1;
                    count++;
                    break;
                }
            }
        }

        int leftOver = 0;
        for(int k = 0; k < nums.Length; k++){
            if(nums[k] != -1)
                leftOver++;
        }

        return new int[]{count,leftOver};
    }
}
