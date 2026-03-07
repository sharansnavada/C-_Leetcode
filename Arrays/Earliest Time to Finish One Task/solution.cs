public class Solution {
    public int EarliestTime(int[][] tasks) {
        int earliestTime = int.MaxValue;

        foreach(int[] arr in tasks){
            int sum = 0;
            foreach(int element in arr){
                sum += element;
            }
            if(sum < earliestTime) earliestTime = sum;
        }

        return earliestTime;
    }
}
