public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int count = 0;
        for(int i = 0; i < words.Length; i++){
            for(int j = i + 1; j < words.Length; j++){
                count += isPrefixAndSuffix(words[i], words[j]) ? 1 : 0;
            }
        }
        return count;
    }

    public bool isPrefixAndSuffix(string str1, string str2){
        if (str1.Length > str2.Length)
            return false;
        for(int i = 0; i < str1.Length; i++){
            if(str1[i] != str2[i])
                return false;
        }
        int pointer = 0;
        for(int j = str2.Length - str1.Length; j < str2.Length; j++){
            if(str1[pointer] != str2[j])
                return false;
            pointer++;
        }
        return true;
    }
}
