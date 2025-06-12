public class Solution {
    public int LongestPalindrome(string s) {
        int longestPal = 0;
        bool isOneLeft = true;
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char letter in s)
        {
            if (dict.ContainsKey(letter))
            {
                dict[letter]++;
            }
            else
            {
                dict[letter] = 1;
            }
        }

        foreach (KeyValuePair<char, int> kvp in dict)
        {
            if (kvp.Value % 2 == 0)
            {
                longestPal += kvp.Value;
            }
            else
            {
                if (isOneLeft)
                {
                    longestPal += kvp.Value;
                    isOneLeft = false;
                }
                else
                {
                    longestPal += kvp.Value - 1;
                }
            }
        }

        return longestPal;
    }
}
