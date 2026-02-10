public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int count = 0;
        foreach(string word in words) {
            int[] hashTable = new int[26]; 
            foreach(char letter in chars) {
                if (letter >= 'a' && letter <= 'z') {
                    hashTable[letter - 'a']++;
                }
            }
            bool valid = true;
            foreach(char c in word) {
                if (c < 'a' || c > 'z') {
                    valid = false;
                    break;
                }
                if (hashTable[c - 'a'] > 0) {
                    hashTable[c - 'a']--;
                } else {
                    valid = false;
                    break;
                }
            }
            if (valid) count += word.Length;
        }
        return count;
    }
}
