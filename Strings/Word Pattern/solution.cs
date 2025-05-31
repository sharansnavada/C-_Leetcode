public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char,string> dict = new Dictionary<char,string>();
        List<string> readyList = new List<string>();
        string[] stringArr= s.Split(' ');
        char[] charArr = pattern.ToCharArray();

        if(pattern.Length != stringArr.Length){
            return false;
        }
        for(int i = 0; i < charArr.Length; i++){
            if(!dict.ContainsKey(charArr[i])){
                if(!readyList.Contains(stringArr[i])){
                    dict[charArr[i]] = stringArr[i]; 
                    readyList.Add(stringArr[i]); 
                }    
                else{
                    return false;
                }         
            }
            else{
                if(dict[charArr[i]] != stringArr[i]){
                    return false;
                }
            }
        }
        return true;
    }
}
