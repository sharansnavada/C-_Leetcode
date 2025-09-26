public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] hashTable = new int[nums.Length + 1];
        int sum = 0;
        int numberAppearedTwice = 0;
        int i = 1;

        foreach(int number in nums){
            hashTable[number]++;
            if(hashTable[number] == 2)
                numberAppearedTwice = number;
            sum += i - number; i++;
            
        }
        
        int[] retArr = new int[]{numberAppearedTwice, (sum + numberAppearedTwice)};
        return retArr;
    }
}
