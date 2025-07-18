public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        int canType = 0;
        string[] strArr = text.Split(' ');

        foreach(string word in strArr){
            bool haveNoLetter = true;
            foreach(char letter in brokenLetters){
                if(word.Contains(letter)){ 
                    haveNoLetter = false;
                    break;
                }
            }
            if(haveNoLetter)
                canType++;
        }
        return canType;
    }
}
