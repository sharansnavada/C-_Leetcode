public class Solution {
    public int BalancedStringSplit(string s) {
        int rCount = 0, lCount = 0;
        int totalMatchCount = 0;
        char rLetter = 'R' , lLetter = 'L';
        
        foreach(char letter in s){
            if(letter == rLetter)
                rCount++;
            else if(letter == lLetter)
                lCount++;
            if(rCount == lCount){
                totalMatchCount++;
                rCount = 0; lCount = 0;
            }
        }

        return totalMatchCount;
    }
}
