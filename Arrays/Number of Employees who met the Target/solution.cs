public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int success = 0;

        foreach(int num in hours){
            if(num >= target){
                success++;
            }
        }
        return success;
    }
}
