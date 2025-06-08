public class Solution {
    public int CountSegments(string s) {
        string[] charArr = s.Split(' ');
        int count = 0;

        bool isSpace = charArr.All(x => x == "");
        if (isSpace)
        {
            return 0;
        }
        
        foreach(string word in charArr){
            if(word != ""){
                count++;
            }
        }
        return count;
    }
}
