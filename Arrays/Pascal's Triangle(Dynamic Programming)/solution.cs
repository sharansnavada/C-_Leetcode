public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> mainList = new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 } };
        IList<int> prevRow = new List<int>();
        int row = 2;

        if(numRows == 1)
        {
            return new List<IList<int>> { new List<int> { 1 } };
        }
        else if(numRows == 2)
        {
            return mainList;
        }
        else
        {
            for(int i = 2; i < numRows; i++)
            {
                IList<int> currentRow = new List<int>();
                currentRow.Add(1);
                prevRow = mainList[row - 1];
                for(int j = 0; j <= prevRow.Count - 2; j++)
                {
                    currentRow.Add(prevRow[j] + prevRow[j + 1]);
                }
                currentRow.Add(1);
                mainList.Add(currentRow);
                row++;
            }
        }
        return mainList;
    }
}
