public class Solution {
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime) {
        
        int time = arrivalTime + delayedTime;
        if(time >= 24)
            return time - 24;
        return time;
    }
}
