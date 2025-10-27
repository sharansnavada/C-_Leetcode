public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int count = 0;
        bool isConsistent = true;
        
        foreach(string word in words){
            foreach(char letter in word){
                if(!allowed.Contains(letter)){
                    isConsistent = false;
                    break;
                }
            }
            if(isConsistent) count++;
            isConsistent = true;
        }
        return count;
    }
}
