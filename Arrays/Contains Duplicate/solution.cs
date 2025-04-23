public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> l = new List<int>();
        foreach(int num in nums){
            if(l.Contains(num)){
                return true;
            }
            else{
                l.Add(num);
            }
        }
        return false;
    }
}
