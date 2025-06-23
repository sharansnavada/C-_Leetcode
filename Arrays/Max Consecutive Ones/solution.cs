public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConsecutive = 0;
        int currentStreak = 0;
        int i = 0;
        while(i < nums.Length){
            if (nums[i] == 1)
            {
                currentStreak++;
                if(currentStreak > maxConsecutive){
                maxConsecutive = currentStreak;
                }
            }
          
            else
            {
                currentStreak = 0;
            }
            i++;
            
        }
        
        return maxConsecutive;
    }
}
