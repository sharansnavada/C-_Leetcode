public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
 
        foreach(char letter in s){
            if(!dict.ContainsKey(letter)) dict[letter] = 0;
            dict[letter]++;
        }
 
        var sortedDict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        StringBuilder sb = new StringBuilder();
 
        foreach(var kvp in sortedDict){
            int n = kvp.Value;
            while(n > 0){
                sb.Append(kvp.Key);
                n--;
            }
        }
        return sb.ToString();
    }
}