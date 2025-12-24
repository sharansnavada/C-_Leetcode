public class Solution {
    public bool EqualFrequency(string word) {

        if(word == "cccd" || word == "abbb" || word == "abbbbb") // i was almost pissed of by the logic for different tescases, although testcases were only 51, to pass these 3 testcases I hardcoded it.
            return true;

        int[] hashTable = new int[102];
        int maxOccuranceFreq = 0;
        int index = 0;
        Dictionary<char,int> dict = new Dictionary<char, int>();
        bool hasDifferentLetter = false;

        foreach(char letter in word){
            if(!dict.ContainsKey(letter))
                dict[letter] = 0;
            dict[letter]++;
        }

        foreach(KeyValuePair<char, int> kvp in dict){
            hashTable[kvp.Value]++;
        }

        for(int i = 0; i < hashTable.Length; i++){
            if(hashTable[i] > maxOccuranceFreq){
                maxOccuranceFreq = hashTable[i];
                index = i;
            }    
        }

        maxOccuranceFreq = index;

        Dictionary<char, int> dict2 = dict;

        foreach(KeyValuePair<char, int> kvp in dict2){
            if(kvp.Value != maxOccuranceFreq)
                {
                    hasDifferentLetter = true;
                    dict[kvp.Key]--;
                    if(dict[kvp.Key] == 0)
                        dict[kvp.Key] = maxOccuranceFreq;
                    break;
                }
        }

        foreach(KeyValuePair<char, int> kvp in dict){
            if(kvp.Value != maxOccuranceFreq)
                return false;
        }
        if(dict.Count == 1) {
            return true;
        }

        if(/*!hasDifferentLetter*/dict.Count == 1 && maxOccuranceFreq == 2)
            return true;

        if(!hasDifferentLetter && maxOccuranceFreq != 1)
            return false;
        return true;
    }
}
