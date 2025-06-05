public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
    List<char> removedLetters = new List<char>();

    for (int i = 0; i < s.Length; i++) {
        if (!dict.ContainsKey(s[i])) {
            if (!removedLetters.Contains(s[i])) {
                dict[s[i]] = i;
            }
        } else {
            dict.Remove(s[i]);
            removedLetters.Add(s[i]);
        }
    }

    foreach (char ch in s) {
        if (dict.ContainsKey(ch)) {
            return dict[ch];
        }
    }
    return -1;
    }
}
