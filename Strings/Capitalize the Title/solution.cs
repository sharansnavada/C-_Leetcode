public class Solution {
    public string CapitalizeTitle(string title) {
        string[] splitString = title.Split(" ");
        StringBuilder sb = new StringBuilder();
        bool isFirstLetter;

        foreach(string word in splitString){
            isFirstLetter = true;
            foreach(char letter in word){
                if(word.Length > 2 && isFirstLetter){
                    sb.Append(char.ToUpper(letter));
                    isFirstLetter = false;
                }
                else{
                    sb.Append(char.ToLower(letter));
                }
            }
            sb.Append(" ");
        }
        return sb.ToString().TrimEnd();
        
    }
}
