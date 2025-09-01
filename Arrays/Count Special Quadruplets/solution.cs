public class Solution {
    public int CountQuadruplets(int[] nums) {
        int count = 0;
        int i = 0, j = 0, k = 0, l = 0;

        for(i = 0; i < nums.Length - 3; i++){
            for(j = i + 1; j < nums.Length - 2; j++){
                for(k = j + 1; k < nums.Length - 1; k++){
                    for(l = k + 1; l < nums.Length; l++){
                        if(nums[i] + nums[j] + nums[k] == nums[l])
                            count++;
                    }
                }
            }
        }
        return count;
    }
}
