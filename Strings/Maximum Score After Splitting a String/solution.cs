public class Solution {
    public int MaxScore(string s) {
        int maxScore = 0;
        int itr = 0;
        while(itr != s.Length){
            int zeroScore = 0, oneScore = 0;
            for(int i = 0; (i <= itr && i < s.Length - 1); i++){
                if(s[i] == '0')
                    zeroScore++;
            }
            for(int j = itr + 1; j < s.Length; j++){
                if(s[j] == '1')
                    oneScore++;
            }
            if((zeroScore + oneScore) > maxScore)
                maxScore = zeroScore + oneScore;
            itr++;
        }
        return maxScore;
    }
}
