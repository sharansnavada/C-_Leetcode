public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> retList = new List<int>();
        int index = 0;

        foreach(string word in words){
            foreach(char letter in word){
                if(letter == x){
                    retList.Add(index);
                    break;
                } 
            }
            index++;
        }
        return retList;
    }
}
