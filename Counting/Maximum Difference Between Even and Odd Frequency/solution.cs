public class Solution {
    public int MaxDifference(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        int oddFreq = int.MinValue;
        int evenFreq = int.MaxValue;
        foreach(char letter in s){
            if(!dict.ContainsKey(letter))
                dict[letter] = 0;
            dict[letter]++;
        }

        foreach(var kvp in dict){
            if(kvp.Value % 2 == 0 && kvp.Value < evenFreq)
                evenFreq = kvp.Value;
            else if(kvp.Value % 2 != 0 && kvp.Value > oddFreq)
                oddFreq = kvp.Value;
        }

        return oddFreq - evenFreq;

    }
}
