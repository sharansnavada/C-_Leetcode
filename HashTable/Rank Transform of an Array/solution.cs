public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        int[] tempArr = new int[arr.Length];
        int index = 0;
        foreach(int n in arr){
            tempArr[index++] = n;
        }
        index = 0;
        tempArr.Sort();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach(int n in tempArr){
            if(!dict.ContainsKey(n)) dict[n] = ++index;
        }

        tempArr = new int[arr.Length];
        index = 0;
        foreach(int num in arr){
            tempArr[index++] = dict[num];
        }
        return tempArr;
    }
}
