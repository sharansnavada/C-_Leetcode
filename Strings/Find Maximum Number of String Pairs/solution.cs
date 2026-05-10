public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        int count = 0;

        for(int i = 0; i < words.Length; i++){
            for(int j = i + 1; j < words.Length; j++){
                if(words[i] == Reversed(words[j])) count++;
            }
        }
        return count;
    }
    public string Reversed(string word){
        StringBuilder sb = new StringBuilder();
        for(int i = word.Length - 1; i >= 0; i--){
            sb.Append(word[i]);
        }
        return sb.ToString();
    }
}
