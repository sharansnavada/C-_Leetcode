public class Solution {
    public int ProjectionArea(int[][] grid) {
        int totalCount = 0;
        int[] hashTable = new int[grid[0].Length];

        for(int i = 0; i < hashTable.Length; i++){
            hashTable[i] = int.MinValue;
        }

        foreach(int[] innerArr in grid){
            int maxNumberAtCurRow = int.MinValue;
            int hashTableIndex = 0;
            foreach(int number in innerArr){
                totalCount += number == 0 ? 0 : 1;
                maxNumberAtCurRow = number > maxNumberAtCurRow ? number : maxNumberAtCurRow;
                hashTable[hashTableIndex] = number > hashTable[hashTableIndex] ? number : hashTable[hashTableIndex];
                hashTableIndex++;
            }
            totalCount += maxNumberAtCurRow;
        }

        foreach(int num in hashTable){
            totalCount += num;
        }

        return totalCount;
        
    }
}

// A Quick Example Walkthrough
// Let's take a small grid: [[1, 2], [3, 4]]

// Top View:

// (0,0) has a tower of 1. (Shadow +1)

// (0,1) has a tower of 2. (Shadow +1)

// (1,0) has a tower of 3. (Shadow +1)

// (1,1) has a tower of 4. (Shadow +1)

// Top Total = 4

// Front View (looking at columns):

// Column 0 has heights 1 and 3. The tallest is 3.

// Column 1 has heights 2 and 4. The tallest is 4.

// Front Total = 3 + 4 = 7

// Side View (looking at rows):

// Row 0 has heights 1 and 2. The tallest is 2.

// Row 1 has heights 3 and 4. The tallest is 4.

// Side View Total = 2 + 4 = 6

// Final Answer: 4 (Top) + 7 (Front) + 6 (Side) = 17.
