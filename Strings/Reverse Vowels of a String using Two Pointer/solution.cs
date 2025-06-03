public class Solution {
    public string ReverseVowels(string s) {
        int i = 0;
        int j = s.Length - 1;
        StringBuilder sb = new StringBuilder(s);
        List<char> vowels = new List<char>{'a','e','i','o','u','A','E','I','O','U'};

        while(i <= j){
            if(vowels.Contains(sb[i])){
                while(!vowels.Contains(sb[j])){
                    j--;
                }
                char temp = sb[j];
                sb[j] = sb[i];
                sb[i] = temp;
                j--;
            }
            i++;
        }
        return sb.ToString();
    }
}
