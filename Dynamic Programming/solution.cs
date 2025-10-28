//JARVIS
public class Solution {
    public int MaxRepeating(string sequence, string word) {
        int maxCount = 0;
        int wordLength = word.Length;
        int sequenceLength = sequence.Length;

        for (int i = 0; i <= sequenceLength - wordLength; i++) {
            int count = 0;
            while (i + count * wordLength + wordLength <= sequenceLength &&
                   sequence.Substring(i + count * wordLength, wordLength) == word) {
                count++;
            }
            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }
}
