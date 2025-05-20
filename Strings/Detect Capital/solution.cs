public class Solution {
    public bool DetectCapitalUse(string word) {
       if(string.IsNullOrEmpty(word)){
        return false;
       }
        if(word.ToUpper() == word){
            return true;
        }
        if(word.ToLower() == word){
            return true;
        }
        if(char.IsUpper(word[0]) && word.Substring(1).ToLower() == word.Substring(1)){
            return true;
        }
        return false;
    }
}
