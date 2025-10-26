public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int n = nums.Length;
        List<int> oddList = new List<int>();
        int[] retArr = new int[n];
        int index = 0;

        foreach(int number in nums){
            if(number % 2 == 0)
                retArr[index++] = number; // if its even number directly add it to the return array
            else
                oddList.Add(number); // if its odd number add it to the seperate list, so that after adding even numbers, no need to again visit entire nums array
        }

        foreach(int number in oddList){
            retArr[index++] = number;
        }

        return retArr;
    }
}
