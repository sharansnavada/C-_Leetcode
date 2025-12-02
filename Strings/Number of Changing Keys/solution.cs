public class Solution {
    public int CountKeyChanges(string s) {
        if(s.Length == 1) return 0;
        int count = 0;
        char currentLetter = s[0];

        for(int i = 1; i < s.Length; i++){
            if(currentLetter == s[i] || currentLetter == char.ToUpper(s[i]) || currentLetter == char.ToLower(s[i])){
                currentLetter = s[i];
            }
            else{
                currentLetter = s[i];
                count++;
            }
        }

        return count;
    }
}
