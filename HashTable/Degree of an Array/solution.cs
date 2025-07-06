public class Solution {
    public int FindShortestSubArray(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        Dictionary<int, int> first = new Dictionary<int, int>();
        int degree = 0;
        int minLength = nums.Length;

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];

            if (!first.ContainsKey(num)) {
                first[num] = i;
            }

            if (count.ContainsKey(num)) {
                count[num]++;
            } else {
                count[num] = 1;
            }

            degree = Math.Max(degree, count[num]);
        }

        foreach (var kvp in count) {
            int num = kvp.Key;
            if (kvp.Value == degree) {
                int start = first[num];
                int end = Array.LastIndexOf(nums, num);
                minLength = Math.Min(minLength, end - start + 1);
            }
        }

        return minLength;
    }
}



//my code
// class smallSub
// {
//     public int FindSmallSubArr(int[] nums)
//     {
//         int maximumDegree = 0;
//         int degreeElement = 0;
//         Dictionary<int, int> dict = new Dictionary<int, int>();
//         Dictionary<int, int> seqDict = new Dictionary<int, int>();
//         int seqCounter = 0;
//         int smallPath = 51000;
//         int loopDegree = 0;
//         int loopPath = 0;

//         foreach (int data in nums)
//         {
//             if (!dict.ContainsKey(data))
//             {
//                 dict[data] = 1;

//                 if (dict[data] > maximumDegree)
//                 {
//                     maximumDegree = dict[data];
//                     degreeElement = data;
//                 }
//             }
//             else
//             {
//                 dict[data]++;

//                 if (dict[data] >= maximumDegree)
//                 {
//                     maximumDegree = dict[data];
//                     degreeElement = data;
//                 }
//             }
//         }

//         foreach (int data in nums)
//         {

//                 if (dict[data] == maximumDegree)
//                 {
//                     seqDict[data] = maximumDegree;
//                 }
            
//         }

//         foreach (KeyValuePair<int, int> kvp in seqDict)
//         {
//             degreeElement = kvp.Key;
//             maximumDegree = kvp.Value;

//             for (int i = 0; i < nums.Length; i++)
//             {
//                 loopDegree = 0; loopPath = 0;
//                 for (int j = i; j < nums.Length; j++)
//                 {
//                     if (nums[j] == degreeElement)
//                         loopDegree++;
//                     loopPath++;
//                     if (loopDegree == maximumDegree)
//                     {
//                         if (loopPath < smallPath)
//                         {
//                             smallPath = loopPath;
//                         }
//                         break;
//                     }
//                 }
//             }
//         }
//         return smallPath;
//     }
// }
