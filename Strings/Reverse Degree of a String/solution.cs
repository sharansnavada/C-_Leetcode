public class Solution {
    public int ReverseDegree(string s) {
        int sum = 0;
        for(int i = 0; i < s.Length; i++){
            sum += (26 - (s[i] - 'a')) * (i + 1);
        }
        return sum;
    }
}
