public class Solution {
    public int FindLucky(int[] arr) {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(int num in arr){
            if(!dict.ContainsKey(num))
                dict[num] = 0;
            dict[num]++;
        }

        int retNum = -1;
        foreach(KeyValuePair<int,int> kvp in dict){
            if(kvp.Key == kvp.Value)
                retNum = Math.Max(retNum,kvp.Key);
        }
        return retNum;
    }
}
