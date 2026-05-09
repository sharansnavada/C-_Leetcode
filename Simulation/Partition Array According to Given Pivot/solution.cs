public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int totalPivots = 0;
        List<int> smallerThanPivot = new List<int>();
        List<int> greaterThanPivot = new List<int>();

        foreach(int number in nums){
            if(number < pivot) smallerThanPivot.Add(number);
            else if (number > pivot) greaterThanPivot.Add(number);
            else if( number == pivot) totalPivots++;
        }
        
        while(totalPivots != 0){
            smallerThanPivot.Add(pivot);
            totalPivots--;
        }

        smallerThanPivot.AddRange(greaterThanPivot);
        return smallerThanPivot.ToArray();
    }
}
