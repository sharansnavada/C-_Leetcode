public class Solution {
    public bool IsValid(string s) {
        Stack<char> stck = new Stack<char>();
        Dictionary<char,char> dict = new Dictionary<char,char>{{')','('},{']','['},{'}','{'}};
        bool isValid = false;
        
        foreach(char c in s){
            if(c == '(' || c == '[' || c == '{'){
                stck.Push(c);
                isValid = false;
            }
            else if(stck.Count != 0){
                if(dict[c] == stck.Peek()){
                    stck.Pop();
                    isValid = true;
                }
                else{
                    isValid = false;
                    break;
                }
            }
            else{
                isValid = false;
                break;
            }
        }
        if(stck.Count == 0){
            return isValid;
        }
        else{
            return false;
        }
        
    }
}
