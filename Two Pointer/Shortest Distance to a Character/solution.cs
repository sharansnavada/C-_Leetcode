public class Solution {
    public int[] ShortestToChar(string s, char c) {
        int[] retArr = new int[s.Length];
        int retArrCounter = 0;

        for(int i = 0; i < s.Length; i++){
            int j = i; int k = i;
            
            while(j < s.Length && k >= 0){
                if(s[j] == c || s[k] == c){
                    retArr[retArrCounter++] = (s[j] == c) ? Math.Abs(i - j) : Math.Abs(i - k); // happy that I got a thought to use "Ternary Operator".
                    break;
                }
                if(j < s.Length - 1)
                    j++;
                if( k > 0)
                    k--;
            }
        }
        return retArr;
    }
}
