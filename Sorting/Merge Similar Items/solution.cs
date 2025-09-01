// instead of using Sorted Dictionary, if you use hash table time-complexity would have been better
public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
        SortedDictionary<int,int> dict = new SortedDictionary<int,int>();

        foreach(int[] arr in items1){
            if(!dict.ContainsKey(arr[0])){
                dict[arr[0]] = arr[1];
            }
        }

        foreach(int[] arr in items2){
            if(!dict.ContainsKey(arr[0])){
                dict[arr[0]] = arr[1];
            }
            else{
                dict[arr[0]] += arr[1];
            }
        }

        int[][] retArr = new int[dict.Count][];
        int dictPointer = 0;

        for(int i = 0; i < retArr.Length; i++){
            var dict1 = dict.ElementAt(dictPointer);
            int[] arr1 = new int[]{dict1.Key, dict1.Value};
            retArr[i] = arr1;
            dictPointer++;
        }
        return retArr;
    }
}
