public class Solution {
    public int CountWords(string[] words1, string[] words2) {
        Dictionary<string, int> words1Dict = new Dictionary<string, int>();
        Dictionary<string, int> words2Dict = new Dictionary<string, int>();
        List<string> strList = new List<string>();
        int count = 0;

        foreach(string word in words1){
            if(!words1Dict.ContainsKey(word))
                words1Dict[word] = 0;
            words1Dict[word]++;
        }

        foreach(string word in words2){
            if(!words2Dict.ContainsKey(word))
                words2Dict[word] = 0;
            words2Dict[word]++;
        }

        foreach(string word in words2){
            if(words1Dict.ContainsKey(word) && words2Dict.ContainsKey(word)){
                if(words1Dict[word] == 1 && words2Dict[word] == 1)
                count++;
            }
        }

        return count;
    }
}
