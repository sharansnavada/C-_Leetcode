public class Solution {
    public int FindMaxK(int[] nums) {
        int[] posHashTable = new int[1002];
        int[] negHashTable = new int[1002];

        foreach(int num in nums){
            if(num >= 0)
                posHashTable[num] = 1;
            else if(num < 0)
                negHashTable[-(num)] = 1;
        }

        for(int i = 1000; i >= 0; i--){
            if(posHashTable[i] == 1 && negHashTable[i] == 1)
                return i;
        }

        return -1;
    }
}
