public class Solution {
    public int MinimumOperations(int[] nums) {
        int minimumOp = 0;

        foreach(int num in nums){
            if(num % 3 != 0){
                if((num + 1) % 3 == 0){
                    minimumOp++;
                }
                else if((num - 1) % 3 == 0){
                    minimumOp++;
                }
            }
        }
        return minimumOp;
    }
}
