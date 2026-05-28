public class Solution {
    public IList<int> PartitionLabels(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        List<int> retArr = new List<int>();
        
        for(int i = 0; i < s.Length; i++){
            if(!dict.ContainsKey(s[i]))
                dict[s[i]] = 0;
            dict[s[i]] = i;
        }

        int totalIndex = 0;

        while(totalIndex < s.Length){
            int counter = 0;
            int endPoint = dict[s[totalIndex]];

            while(totalIndex != (endPoint + 1)){
                if(dict[s[totalIndex]] > endPoint){
                    endPoint = dict[s[totalIndex]];
                }
                counter++; totalIndex++;
            }
            retArr.Add(counter);
            counter = 0;
        }
        return retArr;
    }
}
