public class Solution {
    public bool CheckString(string s) {
        bool foundB = false;

        foreach(char character in s){
            if(character == 'b') foundB = true;
            if(foundB && character == 'a'){
                return false;
            }
        }
        return true;
    }
}
