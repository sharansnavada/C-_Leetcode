public class Solution {
    public string GetEncryptedString(string s, int k) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < s.Length; i++){
            sb.Append(s[(i + k) % s.Length]);
        }
        return sb.ToString();
    }
}
