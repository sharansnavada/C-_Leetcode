public class Solution {
    public bool HalvesAreAlike(string s) {
        int part1 = 0;
        int part2 = 0;
        string vowels = "aeiouAEIOU";

        for(int i = 0; i < s.Length; i++){
            if(i < s.Length / 2){
                if(vowels.Contains(s[i]))
                    part1++;
            }
            else{
                if(vowels.Contains(s[i]))
                    part2++;
            }
        }
        return part1 == part2;
    }
}
