public class Solution {
    public string SortVowels(string s) {
        List<char> vowelsList = new List<char>();
        List<int> vowelIndex = new List<int>();
        StringBuilder sb = new StringBuilder();
        string vowel = "aeiouAEIOU";
        int i = 0;

        for (i = 0; i < s.Length; i++)
        {
            if (vowel.Contains(s[i]))
            {
                vowelsList.Add(s[i]);
                vowelIndex.Add(i);
            }
            sb.Append(s[i]);
        }

        vowelsList.Sort();

        i = 0;
        foreach (char vowelList in vowelsList)
        {
            sb[vowelIndex[i++]] = vowelList;
        }

        return sb.ToString();
    }
}
