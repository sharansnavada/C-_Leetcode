public class Solution {
    public bool CheckIfPangram(string sentence) {
        int[] ht = new int[26];

        for(int i = 0; i < sentence.Length; i++){
            ht[sentence[i] - 'a']++;
        }

        for(int j = 0; j < ht.Length; j++){
            if(ht[j] == 0) return false;
        }
        
        return true;
    }
}
