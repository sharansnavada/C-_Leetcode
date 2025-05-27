public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<IList<int>> mainList = new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 } };
        IList<int> prevRow = new List<int>();
        int row = 2;

        if(rowIndex == 0)
        {
            return new List<int>{1};
        }
        else if(rowIndex == 1)
        {
            return mainList[mainList.Count - 1];
        }
        else
        {
            for(int i = 2; i <= rowIndex; i++)
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
        return mainList[mainList.Count - 1];
    }
}
