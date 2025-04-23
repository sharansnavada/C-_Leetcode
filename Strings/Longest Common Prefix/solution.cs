public class Solution {
    public string LongestCommonPrefix(string[] strs) {
       int index = 0;
        bool firstOne = true;
        char prev = ' ';
        char curr = ' ';
        string word = "";
        bool isSame = true;
        string retString = "";

        int n = strs.Min(s => s.Length);

        while(index < n){
            firstOne = true;
            foreach(string s in strs){
                if(firstOne){
                    word = s;
                    prev = s[index];
                    firstOne = false;
                    continue;
                }
                else{
                    word = s;
                    curr = s[index];
                    if(prev != curr){
                        isSame = false;
                        break;
                    }
                }
            }
            if(isSame){
                retString += prev;
                index++;
            }
            else{
                break;
            }
        }
        return retString;
    }
}
