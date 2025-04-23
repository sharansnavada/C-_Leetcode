public class Solution {
    public bool IsPalindrome(int x) {
        string y = x.ToString();
        bool p = true;

        for(int i = 0,j = y.Length - 1; i < y.Length && j >= 0; i++,j--){
            if(y[i] != y[j]){
                p = false;
                return p;
            }
        }
        return p;
    }
}
