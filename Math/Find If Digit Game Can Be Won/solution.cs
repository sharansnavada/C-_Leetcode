public class Solution {
    public bool CanAliceWin(int[] nums) {
        int singleDigitSum = 0;
        int doubleDigitSum = 0;

        foreach(int number in nums){
            if(number > 9)
                doubleDigitSum += number;
            else
                singleDigitSum += number;
        }

        return singleDigitSum != doubleDigitSum;
    }
}
