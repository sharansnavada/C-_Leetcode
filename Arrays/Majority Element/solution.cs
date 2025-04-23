public class Solution {
    public int MajorityElement(int[] nums) {
        int n = 0;
        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(int num in nums){
            if(!dict.ContainsKey(num)){
                dict[num] = 1;
            }
            else{
                dict[num] += 1;
            }
        }
        var sortedDict = dict.OrderByDescending(p => p.Value);
        foreach(var pair in sortedDict){
            n = pair.Key;
            break;
        }
        return n;
    }
}
