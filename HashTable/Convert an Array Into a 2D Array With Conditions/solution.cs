public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        int sum = 0;
        int[] hashTable = new int[201];
        IList<IList<int>> retList = new List<IList<int>>();

        foreach(int n in nums){
            hashTable[n]++;
            sum = sum + n;
        }

        while(sum > 0){
            List<int> ls = new List<int>();
            for(int i = 0; i < hashTable.Length; i++){
                if(hashTable[i] > 0){
                    ls.Add(i);
                    hashTable[i]--;
                    sum -= i;
                }
            }
            retList.Add(ls);
        }
        return retList;
    }
}
