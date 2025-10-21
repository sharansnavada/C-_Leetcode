public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> freqCounter = new Dictionary<int, int>();
        foreach(int num in arr){
            if(!freqCounter.ContainsKey(num)) freqCounter[num] = 0;
            freqCounter[num]++;
        }

        List<int> freqTracker = new List<int>();
        foreach(KeyValuePair<int, int> kvp in freqCounter){
            if(!freqTracker.Contains(kvp.Value)) freqTracker.Add(kvp.Value);
            else return false;
        }

        return true;
    }
}
