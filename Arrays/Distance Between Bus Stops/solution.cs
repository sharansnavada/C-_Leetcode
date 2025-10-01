public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        int clockSum = 0;
        int antiClockSum = 0;
        int n = distance.Length;
        int clockIndex = (((start) % n) + n) % n, antiClockIndex = ((((start - 1) % n) + n) % n); //this is the most important fromula to traverse the array back and forth with only one looping.

        while(clockIndex != destination || antiClockIndex != ((((destination - 1) % n) + n) % n)){
            if (clockIndex != destination)
            {
                clockSum += distance[clockIndex];
                clockIndex = (((clockIndex + 1) % n) + n) % n;
            }
            if (antiClockIndex != destination - 1)
            {
                antiClockSum += distance[antiClockIndex];
                antiClockIndex = ((((antiClockIndex - 1) % n) + n) % n);
            }
        }
        return Math.Min(clockSum, antiClockSum);
    }
}
