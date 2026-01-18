public class Solution {
    public int SumOfUnique(int[] nums) {
        int[] hashTable = new int[101];
        int count = 0;

        foreach(int num in nums){
            hashTable[num]++;
        }

        for(int i = 0; i < hashTable.Length; i++){
            if(hashTable[i] == 1)
                count += i;
        }
        return count;
    }
}
