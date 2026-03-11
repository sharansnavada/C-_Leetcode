public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        int index = 0;
        int[] retArr = new int[nums.Length];

        while(index != nums.Length){
            int i = index;
            int currentNumber = nums[i];
            int greaterElement = -1;
            do{
                if(nums[i] > currentNumber){
                    greaterElement = nums[i];
                    break;
                } 
                i = i == nums.Length - 1 ? 0 : i + 1;
            } while(i != index);
            retArr[index] = greaterElement;
            index++;
        }

        return retArr;
    }
}
