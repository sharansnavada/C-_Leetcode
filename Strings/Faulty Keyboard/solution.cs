public class Solution {
    public string FinalString(string s) {
        string returnStr = "";

        foreach(char letter in s){
            if(letter != 'i')
                returnStr += letter;
            else
                returnStr = new string(returnStr.Reverse().ToArray());
        }
        return returnStr;
    }
}
