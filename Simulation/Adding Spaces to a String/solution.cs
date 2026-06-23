public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        StringBuilder sb = new StringBuilder();
        int spacesIndex = 0;

        for(int i = 0; i < s.Length; i++){
            if(spacesIndex < spaces.Length)
            {
                if(spaces[spacesIndex] == i){
                    spacesIndex++;
                    sb.Append(' ');
                }
            }
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
}
