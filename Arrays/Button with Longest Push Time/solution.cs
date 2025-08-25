public class Solution {
    public int ButtonWithLongestTime(int[][] events) {
        int prevTime = 0, maxTime = 0;
        int smallestIndex = int.MaxValue;
        int[] indexArr = new int[events.Length];
        int[] timeArr = new int[events.Length];

        for (int i = 0; i < events.Length; i++)
        {
            int[] currEvent = events[i];
            int currIndex = currEvent[0];
            int currTime = currEvent[1] - prevTime;

            prevTime = currEvent[1];

            if (maxTime < currTime)
                maxTime = currTime;
          
            indexArr[i] = currIndex;
            timeArr[i] = currTime;
        }
        for (int j = 0; j < events.Length; j++)
        {
            if (timeArr[j] == maxTime)
            {
                if (smallestIndex > indexArr[j])
                    smallestIndex = indexArr[j];
            }
        }
        return smallestIndex;
    }
}
