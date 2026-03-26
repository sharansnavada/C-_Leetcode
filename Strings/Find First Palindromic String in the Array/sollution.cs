public class Solution {
    public string FirstPalindrome(string[] words) {
        string pal = "";
        foreach(string w in words){
            if(IsPalindrome(w)) return w;
        }
        return pal;
    }

    private bool IsPalindrome(string word){
        int i = 0; int j = word.Length - 1;
        while(i <= j){
            if(word[i] != word[j]){
                return false;
            }
            i++; j--;
        }
        return true;
    }
}
