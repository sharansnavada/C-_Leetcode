public class Solution {
    public int DominantIndex(int[] nums) {
        int largestCounter = 0;
        int loopCounter = 0;
        bool gotIndex = true;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;  //adding elements and their index so as to return their index if we find one, as we are going to sort the nums next.
            }
        }

        Array.Sort(nums);
        Array.Reverse(nums); //so as to make descending order, to start with the highest element first
        int currentLargest = nums[largestCounter];

        while (loopCounter < nums.Length) //will check for every element in the nums
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != currentLargest) //if we encounter the largest element, we have to skip this, as twice the largest we wont check
                {
                    if (currentLargest >= (nums[i] + nums[i]))
                    {
                        gotIndex = true;
                    }
                    else
                    {
                        loopCounter++;
                        gotIndex = false;
                        if (largestCounter < nums.Length - 1)
                        {
                            largestCounter = largestCounter + 1; //we'll take next element as largest as nums is sorted
                        }
                        else
                        {
                            largestCounter = nums.Length - 1; // we'll check this condition to avoid getting the null exception
                        }
                        currentLargest = nums[largestCounter];
                        break;
                    }
                }
                else
                {
                    gotIndex = true;
                }
            }
            if (gotIndex)
            {
                break; //if we get the number twice the all elements, we'll break from the loop, as the first encountered number is enough.
            }
        }

        if (gotIndex)
        {
            return dict[currentLargest];
        }
        else
        {
            return -1;
        }
    }
}
