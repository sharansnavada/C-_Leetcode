public class Solution {
    public int MaxDistinct(string s) {
        int[] hashTable = new int [26];
        int count = 0;

        foreach(char letter in s){
            if(hashTable[letter - 'a'] == 0){
                hashTable[letter - 'a'] = 1;
                count++;
            }
        }
        return count;
    }
}
