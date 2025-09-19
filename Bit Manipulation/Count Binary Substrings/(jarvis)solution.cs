public class Solution {
    public int CountBinarySubstrings(string s) {
        int prevRunLength = 0;  // length of previous group (e.g., consecutive 0s or 1s)
            int curRunLength = 1;   // current group length
            int count = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    curRunLength++;
                }
                else
                {
                    count += Math.Min(prevRunLength, curRunLength);
                    prevRunLength = curRunLength;
                    curRunLength = 1;
                }
            }

            count += Math.Min(prevRunLength, curRunLength);
            return count;
        }
    }
