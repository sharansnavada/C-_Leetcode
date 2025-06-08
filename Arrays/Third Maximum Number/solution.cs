public class Solution {
    public int ThirdMax(int[] nums) {
        HashSet<int> uniqueHash = new HashSet<int>(nums);
        int[] n = new int[uniqueHash.Count];
        uniqueHash.CopyTo(n);
        Array.Sort(n);
        if (n.Length >= 3)
        {
            return n[n.Length - 3];
        }
        else
        {
            return n[n.Length - 1];
        }
        return 0;
    }
}
