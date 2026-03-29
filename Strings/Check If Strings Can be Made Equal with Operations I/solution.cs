public class Solution {
    public bool CanBeEqual(string s1, string s2) {
        StringBuilder sb = new StringBuilder(s1);
        char letter = 'n';

        if(Same(s1, s2)) return true;

        for(int j = 0; j < 4; j++){
            if(j + 2 < 4){
                letter = s1[j];
                sb[j] = sb[j + 2];
                sb[j + 2] = letter;
            }
            if(Same(sb.ToString(), s2)) return true;
        }

        sb = new StringBuilder(s1);
        letter = s1[1];
        sb[1] = sb[3];
        sb[3] = letter;
        if(Same(sb.ToString(), s2)) return true;

        sb = new StringBuilder(s2);

        for(int j = 0; j < 4; j++){
            if(j + 2 < 4){
                letter = s2[j];
                sb[j] = sb[j + 2];
                sb[j + 2] = letter;
            }
            if(Same(sb.ToString(), s1)) return true;
        }

        sb = new StringBuilder(s2);
        letter = s2[1];
        sb[1] = sb[3];
        sb[3] = letter;
        if(Same(sb.ToString(), s1)) return true;

        return false;
    }

    public bool Same(string s, string v){
        for(int i = 0; i < 4; i++){
            if(s[i] != v[i]) return false;
        }
        return true;
    }
}
