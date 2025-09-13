public class Solution {
    public int MaxFreqSum(string s) {
        int[] hashTable = new int[26];
        int maxVowelCount = 0;
        int maxConsonentCount = 0;
        string vowels = "aeiou";

        foreach(char letter in s){
            int asciiValueOfLetter = letter - 'a'; //will get the ascii value of the letter and if we subtract that letter with a's ascii value we will get the index according to the alphabetical order from 0 th index
            hashTable[asciiValueOfLetter]++;
            if(vowels.Contains(letter) && hashTable[asciiValueOfLetter] > maxVowelCount)
                maxVowelCount = hashTable[asciiValueOfLetter];
            else if(!vowels.Contains(letter) && hashTable[asciiValueOfLetter] > maxConsonentCount)
                maxConsonentCount = hashTable[asciiValueOfLetter];
        }
        return maxVowelCount + maxConsonentCount;
    }
}
