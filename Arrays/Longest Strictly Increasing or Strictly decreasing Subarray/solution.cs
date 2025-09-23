public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int pCurrentNumber = 0;
        int nCurrentNumber = 0;
        int prevLongestSubstring = 1, nextLongestSubstring = 1;
        int i = 0;
        int longestAmongPrevNext = 0, longest = 0;
        int n = nums.Length;

        while (i < n)
        {
            pCurrentNumber = nums[i];
            nCurrentNumber = nums[i];
            int prev = i - 1; int next = i + 1;
            while (prev != -1)
            {
                if (pCurrentNumber > nums[prev]) // for strictly increasing(An array is said to be strictly increasing if each element is strictly greater than its previous one (if exists).)
                {
                {
                    prevLongestSubstring++;
                    pCurrentNumber = nums[prev];
                    prev = prev - 1;
                }
                else
                    break;
            }

            while (next != n /*- 1*/)
            {
                if (nCurrentNumber > nums[next]) // for strictly decreasing(An array is said to be strictly decreasing if each element is strictly smaller than its previous one (if exists).)
                    nextLongestSubstring++;
                    nCurrentNumber = nums[next];
                    next = next + 1;
                }
                else
                    break;
            }
            longestAmongPrevNext = prevLongestSubstring >= nextLongestSubstring ? prevLongestSubstring : nextLongestSubstring;
            longest = longestAmongPrevNext > longest ? longestAmongPrevNext : longest;
            prevLongestSubstring = 1; nextLongestSubstring = 1;
            i++;
        }
        return longest;
    }
}
