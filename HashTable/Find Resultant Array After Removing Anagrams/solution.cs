public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        List<string> retList = new List<string>();
        int currentIndex = 1;
        int previousIndex = 0;
        retList.Add(words[0]); //because we wont start iterating from 0th index

        while(currentIndex != words.Length){
            if(!IsAnagrams(words[previousIndex],words[currentIndex])){
                retList.Add(words[currentIndex]);
                previousIndex = currentIndex;
            }
            currentIndex++;
        }
        return retList;
    }

    public bool IsAnagrams(string word1, string word2){
        char[] word1HashTable = new char[26];
        char[] word2HashTable = new char[26];

        foreach(char letter in word1){
            word1HashTable[letter - 'a']++;
        }

        foreach(char letter in word2){
            word2HashTable[letter - 'a']++;
        }

        for(int i = 0; i < 26; i++){
            if(word1HashTable[i] != word2HashTable[i])
                return false;
        }

        return true;
    }
}
