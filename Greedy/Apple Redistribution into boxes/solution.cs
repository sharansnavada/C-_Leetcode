public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        Array.Sort(capacity);
        int count = 0, capacityLength = capacity.Length, capacityPointer = capacityLength - 1;
        int appleLength = apple.Length;


        for (int i = 0; i < appleLength; i++)
        {
            if (i == appleLength - 1)
            {
                if (apple[i] == capacity[capacityPointer]) //for moving in to the new boxes, we have already been incremented the count, but if the apple size and box size is same, for avoiding the double increment, I am drecrementing one value.
                {
                    count--;
                    //continue;
                }
            }
            if (apple[i] <= capacity[capacityPointer])
            {
                capacity[capacityPointer] -= apple[i];
                if (capacity[capacityPointer] == 0)
                {
                    capacityPointer--;
                    count++;
                }
            }
            else if (apple[i] > capacity[capacityPointer])
            {
                apple[i] = apple[i] - capacity[capacityPointer];
                capacity[capacityPointer] = 0;
                capacityPointer--; count++; i--;
                if (capacityPointer == -1 && apple[i] > 0)
                    return -1;
            }
        }
        return count + 1;
    }
}
