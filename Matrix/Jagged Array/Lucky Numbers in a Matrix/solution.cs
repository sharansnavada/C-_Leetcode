public class luckym {
    public IList<int> LuckyNumbers(int[][] matrix) {
        int row = 0, column = 0;
        List<int> luckyNumbers = new List<int>();
        bool isMax = false;

        for(int i = 0; i < matrix.Length; i++){
            int minNumInRow = int.MaxValue;
            for(int j = 0; j < matrix[i].Length; j++){
                if(matrix[i][j] < minNumInRow){
                    minNumInRow = matrix[i][j];
                    row = i; column = j;
                }
            }
            for(int k = 0 ; k < matrix.Length; k++){
                if(minNumInRow > matrix[k][column])
                    isMax = true;
                else if(k != row)
                    isMax = false;
            }
            if(isMax)
                luckyNumbers.Add(minNumInRow);
        }

        return luckyNumbers;
    }
}
