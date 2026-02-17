public class Solution {
    public int AlternatingSum(int[] nums) {
        int altSum = 0;
        bool isEvenIndices = true;

        foreach(int num in nums){
            if(isEvenIndices) altSum += num;
            else altSum -= num;
            isEvenIndices = !isEvenIndices;
        }
        return altSum;
    }
}
