public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxWords = int.MinValue;
        int innerLoopCount = 0;

        foreach(string word in sentences){
            foreach(char letter in word){
                if(letter == ' ')
                    innerLoopCount++;
            }
            innerLoopCount++;
            if(maxWords < innerLoopCount)
                maxWords = innerLoopCount;
            innerLoopCount = 0;
        }
        return maxWords;
    }
}
