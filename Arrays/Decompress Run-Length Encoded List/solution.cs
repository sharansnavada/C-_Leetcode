public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> retList = new List<int>();
        for(int i = 0; i < nums.Length - 1; i = i + 2){
            int itr = nums[i];
            while(itr != 0){
                retList.Add(nums[i + 1]);
                itr--;
            }
        }
        return retList.ToArray();
    }
}
