public class Solution {
    public int MaximumLengthSubstring(string s) {
        int retCount = -1;
        int[] hashTable = new int[26];
        int counter = 0;

        for(int i = 0; i < s.Length; i++){
            for(int j = i; j < s.Length; j++)
            {
                if(hashTable[s[j] - 'a'] < 2){
                    hashTable[s[j] - 'a']++;
                    counter++;
                }
                else{
                  retCount = retCount > counter ? retCount : counter;
                    counter = 0;
                    hashTable = new int[26];
                    break;
                }
            }

            retCount = retCount > counter ? retCount : counter;
            counter = 0;
        }

        return retCount > counter ? retCount : counter;
    }
}
