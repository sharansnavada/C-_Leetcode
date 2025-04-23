public class Solution {
    public int RomanToInt(string s) {
        int num = 0;
        Dictionary<char, int> dict = new Dictionary<char,int>{{'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}};
        for(int i = 0;i<s.Length;i++){
            if((i!=s.Length-1) && (((s[i] == 'I') && ((s[i+1] == 'V') || (s[i+1] == 'X'))) || ((s[i] == 'X') && ((s[i+1] == 'L') || (s[i+1] == 'C'))) || ((s[i] == 'C') && ((s[i+1] == 'D') || (s[i+1] == 'M'))))){
                num += dict[s[i+1]] - dict[s[i]];
                i++;
            }
            else{
                num += dict[s[i]];
            }
        }
        return num;
    }
}
