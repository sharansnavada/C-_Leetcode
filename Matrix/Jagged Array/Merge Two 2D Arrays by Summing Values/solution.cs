public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for(int i = 0; i < nums1.Length; i++){
            for(int j = 0; j < nums1[i].Length; j++){
                if(!dict.ContainsKey(nums1[i][j])){
                    dict[nums1[i][j]] = nums1[i][j + 1];
                    j = j + 1;
                }
            }
        }

        for(int i = 0; i < nums2.Length; i++){
            for(int j = 0; j < nums2[i].Length; j++){
                if(!dict.ContainsKey(nums2[i][j])){
                    dict[nums2[i][j]] = nums2[i][j + 1];
                    j = j + 1;
                }
                else{
                    dict[nums2[i][j]] += nums2[i][j + 1];
                    j = j + 1;
                } 
            }
        }

        var sortedDict = dict.OrderBy(x => x.Key).ToList();
        int[][] retArr = new int[sortedDict.Count][];

        for (int i = 0; i < sortedDict.Count; i++)
        {
            retArr[i] = new[] { sortedDict[i].Key, sortedDict[i].Value };
        }

        return retArr;
    }
}
