public class Solution {
    public int[] TransformArray(int[] nums) {
        int[] retArr = new int[nums.Length];
        int ones = 0;
        int zeros = 0;

        foreach(int n in nums){
            if(n % 2 == 0) zeros++;
            else ones++; 
        }

        int index = 0;

        while(zeros != 0){
            retArr[index++] = 0;
            zeros--;
        }
        while(ones != 0){
            retArr[index++] = 1;
            ones--;
        }

        return retArr;
    }
}
