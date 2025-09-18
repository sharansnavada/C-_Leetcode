public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        if(words.Count != s.Length)
            return false;
        int index = 0;
        foreach(string word in words){
            if(word[0] != s[index])
                return false;
            index++;
        }
        return true;
    }
}
