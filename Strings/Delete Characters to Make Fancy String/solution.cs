public class Solution {
    public string MakeFancyString(string s) {
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < s.Length; i++){
            if( ((i + 1) < s.Length - 1) && ((i + 2) < s.Length)){
                if(s[i] != s[i + 1] || s[i] != s[i + 2])
                    sb.Append(s[i]);
            }
            else{
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
}
