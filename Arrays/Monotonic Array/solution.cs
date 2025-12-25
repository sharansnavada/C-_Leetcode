public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool isMonoInc = true;
        bool isMonoDec = true;

        int firstNumber = nums[0];

        foreach(int number in nums){
            if(isMonoInc || isMonoDec){
                if(number >= firstNumber && isMonoInc)
                 isMonoInc = true;
                else
                 isMonoInc = false;
                if(number <= firstNumber && isMonoDec)
                 isMonoDec = true;
                else
                 isMonoDec = false;
            }
            else
                return false;
            firstNumber = number;
        }

        if(isMonoInc)
            return isMonoInc;
        else if(isMonoDec)
            return isMonoDec;
        return false;
    }
}
