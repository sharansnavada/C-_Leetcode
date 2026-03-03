public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int longestSequence = 0;
        int index = 0;
        int length = 0;

        int loopLongestSequence = 0;
        foreach(int n in nums){
            if(n == 1) loopLongestSequence++;
            else {
                longestSequence = loopLongestSequence > longestSequence ? loopLongestSequence : longestSequence;
                loopLongestSequence = 0;
            }
            length++;
        }

        if(longestSequence >= length - k) return longestSequence + k;
        longestSequence = 0;
        loopLongestSequence = 0;

        int loopLength = length - 1;
        int loopK = k;
        int loopIndex = index;
        
        while(loopIndex < length)
        {
            for(int i = loopIndex; i < length; i++)
            {
                if(nums[i] == 1) loopLongestSequence++;
                else if(nums[i] == 0 && loopK > 0)
                {
                    loopLongestSequence++;
                    loopK--;
                }
                else
                {
                    break;
                }
            }
            index++;
            loopIndex = index;
            longestSequence = loopLongestSequence > longestSequence ? loopLongestSequence : longestSequence;
            loopLongestSequence = 0;
            loopK = k;
        }

        return longestSequence;
    }
}


// but the most optimal solution would be solving this
// problem using SLIDING WINDOW concept.
  
// public class Solution {
//     public int LongestOnes(int[] nums, int k) 
//     {
//         int left = 0;
//         int zeroCount = 0;
//         int maxLength = 0;

//         for (int right = 0; right < nums.Length; right++)
//         {
//             if (nums[right] == 0)
//                 zeroCount++;

//             while (zeroCount > k)
//             {
//                 if (nums[left] == 0)
//                     zeroCount--;
//                 left++;
//             }

//             int windowLength = right - left + 1;
//             maxLength = windowLength > maxLength ? windowLength : maxLength;
//         }

//         return maxLength;
//     }
// }
