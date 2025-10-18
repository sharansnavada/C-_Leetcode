public class Solution {
    public int[] FrequencySort(int[] nums) {
        // Step 1: Count frequency of each number
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            if (freq.ContainsKey(n))
                freq[n]++;
            else
                freq[n] = 1;
        }

        // Step 2: Sort using LINQ
        // Sort by frequency ascending, and then by value descending
        var sorted = nums
            .OrderBy(n => freq[n])   // increasing frequency
            .ThenByDescending(n => n) // decreasing value if same frequency
            .ToArray();

        return sorted;
    }
}


//This code did not passed all the testcases

// public class Solution {
//     public int[] FrequencySort(int[] nums) {
//         int n = nums.Length;
//         int[] retArr = new int[n]; int retArrIndex = 0;
//         int[] positiveHashTable = new int[101];
//         int[] negativeHashTable = new int[101];
//         int addedElements = 0;
//         int freq = 1;

//         for(int i = 0; i < n; i++){
//             if(nums[i] >= 0)
//                 positiveHashTable[nums[i]]++;
//             else
//                 negativeHashTable[-(nums[i])]++;
//         }

//         while (addedElements != n)
//         {
//             List<int> freqList = new List<int>();
//             for (int j = 0; j < 101; j++)
//             {
//                 if (positiveHashTable[j] == freq)
//                     freqList.Add(j);
//                 if (negativeHashTable[j] == freq)
//                     freqList.Add(-(j));
//             }
//             freqList.Sort();
//             //int whileFreq = freq;
//             for (int k = freqList.Count - 1; k >= 0; k--)
//             {
//                 int whileFreq = freq * freqList.Distinct().Count();
//                 bool haveDistinctEle = whileFreq == freqList.Distinct().Count();
//                 while (whileFreq != 0)
//                 {
//                     retArr[retArrIndex++] = freqList[k];
//                     whileFreq--;
//                     addedElements++;
//                     if (haveDistinctEle)
//                         k--;
//                     else if ((int)(whileFreq % freqList.Distinct().Count()) == 0 && freqList.Distinct().Count() > 1)
//                         k--;
//                 }
//             }
//             freq++;
//         }
//         return retArr;
//     }
// }
