public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        List<string> retStr = new List<string>();
        foreach(string word in words){
            string[] splittedStr = word.Split(separator);
            foreach(string innerWord in splittedStr){
            if(innerWord != "") retStr.Add(innerWord);
            }
        }
        return retStr;
    }
}
