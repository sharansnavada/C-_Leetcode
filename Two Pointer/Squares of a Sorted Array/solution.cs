public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
            int loopn = nums.Length;
            int minNumber = 0;
            int index = 0;

            while (n != 0)
            {
                minNumber = int.MaxValue;
                int currIndex = -1;

                for (int i = index; i < loopn; i++)
                {
                    if (Math.Abs(nums[i]) < minNumber)
                    {
                        minNumber = Math.Abs(nums[i]);
                        currIndex = i;
                    }
                }

                if(index == currIndex)
                {
                    //nums[index++] = (int)Math.Sqrt(minNumber);
                    nums[index++] = minNumber * minNumber;
                }
                    
                else
                {
                    int temp = nums[index];
                    nums[index++] = minNumber * minNumber;
                    nums[currIndex] = temp;
                }


                n--;
            }
            return nums;
    }
}
