public class Solution {
    public int ArraySign(int[] nums) {
        BigInteger num = 1;
        for(int i = 0; i < nums.Length; i++){
            num *= nums[i];
        }
 
        if(num == 0) return 0;
        if(num < 0) return -1;
        if(num > 0) return 1;
 
        return 99;
    }
}