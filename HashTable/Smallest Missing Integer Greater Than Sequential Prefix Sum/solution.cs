public class Solution {
    public int MissingInteger(int[] nums) {
        int previousNumber = nums[0];
        int sequentialSum = nums[0];
        bool sequenceBroke = false;
        bool hasSequentialSumInNums = false;
        int[] hashTable = new int[52];
        hashTable[nums[0]] = 1;
        
        for(int i = 1; i < nums.Length; i++){
            if(!sequenceBroke){
                if(nums[i] == previousNumber + 1)
                    sequentialSum += nums[i];
                else
                {
                    sequenceBroke = true;
                    hasSequentialSumInNums = nums[i] == sequentialSum ? true : false;
                }
                previousNumber = nums[i];
                hashTable[nums[i]] = 1;
            }
            else{
                if(nums[i] == sequentialSum){
                    hashTable[nums[i]] = 1;
                    hasSequentialSumInNums = true;
                    //break;
                }
                hashTable[nums[i]] = 1;
            }
        }

        hasSequentialSumInNums = nums[0] == sequentialSum ? true : hasSequentialSumInNums;

        if(!hasSequentialSumInNums && nums.Length != 1)
            return sequentialSum;

        for(int j = sequentialSum; j < hashTable.Length; j++){
            if(hashTable[j] == 0)
                return j;
        }

        return 0;
    }
}
