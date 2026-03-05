public class Solution {
    public string ReversePrefix(string s, int k) {
        StringBuilder sb = new StringBuilder();

        for(int i = k - 1; i >= 0; i--){
            sb.Append(s[i]);
        }

        for(int i = k; i < s.Length; i++){
            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}
