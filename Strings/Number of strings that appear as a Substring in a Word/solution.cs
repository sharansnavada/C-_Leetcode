public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int count = 0;
        foreach(string subString in patterns){
            if(word.Contains(subString))
                count++;
        }
        return count;
    }
}
