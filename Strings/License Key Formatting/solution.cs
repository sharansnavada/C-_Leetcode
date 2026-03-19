public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        StringBuilder sb = new StringBuilder();
        int wordLength = 0;

        for(int i = s.Length - 1; i > -1; i--){
            if(char.IsLetterOrDigit(s[i])) sb.Insert(0,char.ToUpper(s[i]));
            else continue;
            wordLength++;
            if(wordLength == k){
                wordLength = 0;
                sb.Insert(0, '-');
            }
        }
        return sb.ToString().Trim('-');
    }
}
