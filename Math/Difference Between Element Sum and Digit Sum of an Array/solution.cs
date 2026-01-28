public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int actualSum = 0;
        int splitSum = 0;

        foreach(int num in nums){
            actualSum += num;
            if(num > 9){
                string strNum = num.ToString();
                foreach(char digit in strNum){
                    splitSum += int.Parse(digit.ToString());
                } 
            }
            else{
                splitSum += num;
            }
        }

        return actualSum - splitSum;
    }
}
