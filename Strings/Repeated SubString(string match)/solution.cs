public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for(int i =1; i <= s.Length / 2; i++){
            if(s.Length % i == 0){
                string sub = s.Substring(0,i);
                string ret = "";
                for(int j = 0; j < s.Length / i; j++){
                    ret += sub;
                }
                if(ret == s){
                    return true;
                }
            }
        }
        return false;
    }
}

Above my code has the time complexity of O(NSquare) but some one did it with optimized code.
// public class Solution {
//     public bool RepeatedSubstringPattern(string s) {

//     string doubled = s + s;
//     string trimmed = doubled.Substring(1, doubled.Length - 2);
//     return trimmed.Contains(s);

//     }
// }
