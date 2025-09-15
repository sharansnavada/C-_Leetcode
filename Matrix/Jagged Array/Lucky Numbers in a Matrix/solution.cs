public class luckym {
    public IList<int> LuckyNumbers(int[][] matrix) {
        int column = 0;
        List<int> luckyNumbers = new List<int>();

        for(int i = 0; i < matrix.Length; i++){
            int minNumInRow = int.MaxValue;
            for(int j = 0; j < matrix[i].Length; j++){
                if(matrix[i][j] < minNumInRow){
                    minNumInRow = matrix[i][j];
                    column = j;
                }
            }
            bool isMax = true;
            for (int k = 0; k < matrix.Length; k++) {
                if (matrix[k][column] > minNumInRow) {
                    isMax = false;
                    break;
                }
            }
            if(isMax)
                luckyNumbers.Add(minNumInRow);
        }

        return luckyNumbers;
    }
}
