public class Solution {
    public int MinimizedStringLength(string s) {
        List<char> charList  = new List<char>();
        int count = 0;

        foreach(char letter in s){
            if(!charList.Contains(letter)){
                count++;
                charList.Add(letter);
            }
        }

        return count;
    }
}
