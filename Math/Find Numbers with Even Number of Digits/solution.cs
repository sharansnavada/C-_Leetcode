public class Solution {
    public int FindNumbers(int[] nums) {
        int evenCount = 0;
        foreach(int number in nums){
            if(number.ToString().Length % 2 == 0)
                evenCount++;
        }
        return evenCount;
    }
}
