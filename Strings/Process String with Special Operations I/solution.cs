public class Solution {
    public string ProcessStr(string s) {
        StringBuilder sb = new StringBuilder();
        
        foreach(char character in s){
            switch(character){
                case '*': if(sb.Length > 0) sb.Length--;
                          break;
                case '#': sb.Append(sb);
                          break;
                case '%': sb = Reverse(sb);
                          break;
                default: sb.Append(character);
                         break;
            }
        }
        return sb.ToString();
    }

    public StringBuilder Reverse(StringBuilder str){
        StringBuilder sb = new StringBuilder();
        for(int i = str.Length - 1; i >= 0; i--){
            sb.Append(str[i]);
        }
        return sb;
    }
}
