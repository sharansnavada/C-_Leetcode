public class Solution {
    public int FindGCD(int[] nums) {
        int minEle = int.MaxValue;
        int maxEle = int.MinValue;
        int gcd = 0;

        foreach(int n in nums){
            minEle = n < minEle ? n : minEle;
            maxEle = n > maxEle ? n : maxEle;
        }

        for(int i = 1; i <= (maxEle); i++){
            if(minEle % i == 0 && maxEle % i == 0) gcd = i;
        }
        return gcd;
    }
}
