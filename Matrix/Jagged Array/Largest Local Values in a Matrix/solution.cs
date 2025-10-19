public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        List<int> addList = new List<int>();
            int[][] largestLocal = new int[grid.Length - 2][];
            int row = 0, column = 0;
            for(int i = 0; i < grid.Length - 2; i++) // no need of checking last two rows.
            {
                int[] arr1 = grid[i]; int[] arr2 = grid[i + 1]; int[] arr3 = grid[i + 2]; // take strictly below 3 rows to evaluate the largest numbers in them 
                int index = 0; 
                while(index != arr1.Length - 2) // no need of considering the last to columns
                {
                    int maxNumber = int.MinValue; //reset the min value after checking each instance
                    for(int j = index; j < index + 3; j++) // loop for iterating the each element in 3x3 matrix 
                    {
                        if (arr1[j] > maxNumber)
                            maxNumber = arr1[j];
                        if (arr2[j] > maxNumber)
                            maxNumber = arr2[j];
                        if (arr3[j] > maxNumber)
                            maxNumber = arr3[j];
                    }

                    addList.Add(maxNumber);
                    column++;
                    
                    if(column == grid.Length - 2) // after checking that entire 3 rows, convert the list to array add it in to the jagged array and increment the row value
                    {
                        largestLocal[row] = addList.ToArray();
                        addList = new List<int>();
                        row++; column = 0;
                    }

                    index++;
                }
            }

            return largestLocal;
    }
}
