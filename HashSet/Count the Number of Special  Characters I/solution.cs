public class Solution {
    public int NumberOfSpecialChars(string word) {
        char[] charArr = word.ToCharArray();
        HashSet<char> hashSet = new HashSet<char>();
        int[] upperTable = new int[26];
        int[] lowerTable = new int[26];
        int count = 0;

        foreach(char letter in charArr){
            hashSet.Add(letter);
        }

        foreach(char letter in hashSet){
            if(char.IsUpper(letter)){
                if(lowerTable[char.ToLower(letter) - 'a'] == 1){
                    count++;
                    lowerTable[char.ToLower(letter) - 'a'] = 2;
                    upperTable[char.ToLower(letter) - 'a'] = 2;
                }
                else{
                    upperTable[char.ToLower(letter) - 'a'] = 1;
                }
            }
            else{
                if(upperTable[char.ToLower(letter) - 'a'] == 1){
                    count++;
                    lowerTable[char.ToLower(letter) - 'a'] = 2;
                    upperTable[char.ToLower(letter) - 'a'] = 2;
                }
                else{
                    lowerTable[char.ToLower(letter) - 'a'] = 1;
                }
            }
        }

        return count;

    }
}
