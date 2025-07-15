public class Solution {
    public int[] DistinctDifferenceArray(int[] nums) {
        int [] result = new int [nums.Length];
        for(int i = 0 ; i < nums.Length ; i++)
        {
            result[i] = CountDistinctElement(nums, 0, i) - CountDistinctElement(nums, i + 1, nums.Length - 1);
        }
        return result;
    }

    public int CountDistinctElement(int [] nums, int start, int end)
    {
        bool [] visited = new bool [51];
        int count = 0;
        for(int i = start ; i <= end ; i++)
        {
            if(!visited[nums[i]])
            {
                visited[nums[i]] = true;
                count++;
            }
        }
        return count;
    }
}

//My code, with same logic but with not good time complexity because, I am using List to add the elements
//While adding and to find the length, it has to iterate the List, so having not optimal time complexity
//above code they have used hashtable which is optimal

// public class Solution {
//     public int[] DistinctDifferenceArray(int[] nums) {
//         int[] retArr = new int[nums.Length];
//         int prefix = 0; int i = 0; int suffix = 0;
//         List<int> preList = new List<int>();
//         List<int> sufList = new List<int>();

//         while(i < nums.Length){
//             while(prefix != i + 1){
//                 if(!preList.Contains(nums[prefix]))
//                     preList.Add(nums[prefix]);
//                 prefix++;
//             }
//             suffix = i + 1;
//             while(suffix != nums.Length){
//                 if(!sufList.Contains(nums[suffix]))
//                     sufList.Add(nums[suffix]);
//                 suffix++;
//             }
//             retArr[i] = preList.Count - sufList.Count;
//             preList = new List<int>();
//             sufList = new List<int>();
//             i++; prefix = 0;
//         }
//         return retArr;
//     }
// }

