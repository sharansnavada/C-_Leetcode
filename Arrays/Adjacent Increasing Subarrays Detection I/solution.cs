public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        bool strictlyIncreasing = false;

        for(int i = 0; i <= nums.Count - (k + k); i++){ // if arr count is 10 and k is 3, i should run only till 10 - (3 + 3)
            int currentNumber = int.MinValue; //reset after each subarrays comparision to proceed for an other
            int index = 0;
            for (int j = i; j < i + (k + k); j++) // for the two subarrays
            {
                if (index == k) // reset the current number to min so that we should check the strictly increasing to 2 seperate subarrays not for combined
                    currentNumber = int.MinValue;
                if (nums[j] > currentNumber)
                    {
                        currentNumber = nums[j];
                        strictlyIncreasing = true;
                    }
                    else
                    {
                        strictlyIncreasing = false;
                        break;
                    }
                index++;
            }
            if(strictlyIncreasing)
                return true; //if we get one, return true, no need to check further.
        }
        return strictlyIncreasing;
    }
}
