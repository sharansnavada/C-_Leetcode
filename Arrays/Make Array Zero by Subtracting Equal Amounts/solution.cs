public class Solution {
    public int MinimumOperations(int[] nums) {
        int sum = nums.Sum();
        int iteration = 0;
        
        while(sum != 0){
            int smallest = returnSmallest(nums);
            for(int i = 0; i < nums.Length; i++){
                nums[i] = (nums[i] - smallest) <= 0 ? 0 : (nums[i] - smallest);
            }
            sum = nums.Sum();
            iteration++;
        }
        return iteration;
    }

    public int returnSmallest(int[] nums){
        int smallest = int.MaxValue;
        foreach(int num in nums){
            if(num < smallest && num > 0)
                smallest = num;
        }
        return smallest;
    }
}
