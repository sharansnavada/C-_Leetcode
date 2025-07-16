public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int[] rightSum = new int[nums.Length];
        int[] leftSum = new int[nums.Length];
        int i = 0; int j = 0;

        while (i < nums.Length)
        {
            int sum = 0;
            j = i + 1;
            while (j < nums.Length)
            {
                sum += nums[j];
                j++;
            }
            leftSum[i] = sum;
            i++;
        }

        i = nums.Length - 1;

        while (i > -1)
        {
            int sum = 0;
            j = i - 1;
            while (j > -1)
            {
                sum += nums[j];
                j--;
            }
            rightSum[i] = sum;
            i--;
        }

        int[] retArr = new int[nums.Length];
        for(int k = 0; k < nums.Length; k++){
            retArr[k] = Math.Abs(leftSum[k] - rightSum[k]);
        }
        return retArr;
    }
}
