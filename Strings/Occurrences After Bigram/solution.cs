public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        List<string> retArr = new List<string>();
        string[] splitText = text.Split(' ');
        int n = splitText.Length;

        for(int i = 0; i < n - 2; i++){
            if(splitText[i] == first && splitText[i + 1] == second)
                retArr.Add(splitText[i + 2]);
        }
        return retArr.ToArray();
    }
}
