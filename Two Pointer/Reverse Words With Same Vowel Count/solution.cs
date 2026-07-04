public class Solution {
    public string ReverseWords(string s) {
        int vowelCount = 0;
        string vowels = "aeiou";
        string[] strArr = s.Split(' ');
        if(strArr.Length == 1) return s;
        StringBuilder sb = new StringBuilder();

        foreach(char letter in strArr[0]){
            if(vowels.Contains(letter)) vowelCount++;
        }

        sb.Append(strArr[0]);
        sb.Append(" ");

        for(int i = 1; i < strArr.Length; i++){
            int internalVowelCount = 0;
            foreach(char letter in strArr[i]){
                if(vowels.Contains(letter)) internalVowelCount++;
            }
            if(internalVowelCount == vowelCount){
                sb.Append(ReverseStr(strArr[i]));
                if(i != strArr.Length - 1) sb.Append(" ");
            }
            else{
                sb.Append(strArr[i]);
                if(i != strArr.Length - 1) sb.Append(" ");
            }
        }

        return sb.ToString();
    }

    StringBuilder ReverseStr(string str){
        StringBuilder sb = new StringBuilder();
        for(int i = str.Length - 1; i >= 0; i--){
            sb.Append(str[i]);
        }
        return sb;
    }
}
