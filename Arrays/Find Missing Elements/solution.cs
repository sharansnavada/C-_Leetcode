public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        Array.Sort(nums);
        int startIndex = nums[0];
        int endIndex = nums[nums.Length - 1];
        List<int> retList = new List<int>();

        for(int i = startIndex; i <= endIndex; i++){
            if(!nums.Contains(i))
                retList.Add(i);
        }
        return retList;
    }
}
