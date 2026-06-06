public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> retStr = new List<string>();
        if(nums.Length == 0) return retStr;
        int[] hashTable = new int[nums[nums.Length - 1] + 1];

        foreach(int n in nums){
            hashTable[n] = 1;
        }

        bool startElement = true;
        int index = 0;
        for(int i = 0; i < hashTable.Length; i++){
            if(hashTable[i] == 1){
                if(startElement){
                    startElement = false;
                    index = i;
                }
                else{

                }
            }
            else{
                startElement = true;
                if(index != -1){
                    if(index != i - 1)
                    {
                        retStr.Add(index.ToString() + "->" + (i - 1).ToString());
                    }
                    else
                    {
                        retStr.Add(index.ToString());
                    }
                    index = -1;
                }
            }
        }

        if(!startElement){
            if(index != hashTable.Length - 1)
            {
                retStr.Add(index.ToString() + "->" + (hashTable.Length - 1).ToString());
            }
            else
            {
                retStr.Add(index.ToString());
            }
        }

        return retStr;
    }
}
