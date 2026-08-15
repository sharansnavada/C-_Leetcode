public class Solution {
    public int BeautySum(string s) {
        int retBeauty = 0;

        for(int i = 0; i < s.Length; i++){
            Dictionary<char, int> freq = new Dictionary<char, int>();
            for(int j = i; j < s.Length; j++){
                if(!freq.ContainsKey(s[j])) freq[s[j]] = 0;
                freq[s[j]]++;
                int newBeauty = DetermineBeautyNumber(freq);
                retBeauty += newBeauty != 0 ? newBeauty : 0;
            }
        }
        return retBeauty;
    }

    int DetermineBeautyNumber(Dictionary<char, int> freq){
        int highest = 0;
        int lowest = 600;

        foreach(KeyValuePair<char, int> kvp in freq)
        {
            highest = kvp.Value > highest ? kvp.Value : highest;
            lowest = kvp.Value < lowest ? kvp.Value : lowest;
        }

        return (highest - lowest);
    }
}
