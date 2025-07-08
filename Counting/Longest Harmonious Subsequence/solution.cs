//try [1, 3, 2, 2, 5, 2, 3, 7]
public class Solution {
    public int FindLHS(int[] nums) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
    foreach (int num in nums)
    {
        if (!freq.ContainsKey(num))
            freq[num] = 0;
        freq[num]++;
    }

    int longest = 0;
    foreach (var kvp in freq)
    {
        int key = kvp.Key;
        if (freq.ContainsKey(key + 1))
        {
            longest = Math.Max(longest, freq[key] + freq[key + 1]);
        }
    }

    return longest;
    }
}
