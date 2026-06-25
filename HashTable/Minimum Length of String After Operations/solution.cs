public class Solution {
    public int MinimumLength(string s) {
        if(s.Length < 3) return s.Length;
        
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int count = 0;

        foreach(char letter in s){
            if(!dict.ContainsKey(letter)) dict[letter] = 0;
            dict[letter]++;
        }

        foreach(KeyValuePair<char, int> kvp in dict){
            if(kvp.Value < 3){
                count += kvp.Value;
                continue;
            } 
            else{
                int freq = kvp.Value;
                while(freq >= 3){
                    freq -= 2;
                }
                count += freq;
            } 
        }
        return count;
    }
}
