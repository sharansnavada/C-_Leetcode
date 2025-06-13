public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach(char letter in s){
            if(char.IsDigit(letter) || char.IsLetter(letter)){
                sb.Append(char.ToLower(letter));
            }
        }
        string builderString = sb.ToString();
        for(int i = 0, j = sb.Length - 1; i <= j ; i++, j--){
            if(builderString[i] != builderString[j]){
                return false;
            }
        }
        return true;

    }
}
