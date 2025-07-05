public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        int listCounter = 0;
        int[][] retMat = new int[r][];
        List<int> dataList = new List<int>();
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                dataList.Add(mat[i][j]);
            }
        }

        if (dataList.Count != (r * c))
        {
            return mat;
        }

        for (int i = 0; i < r; i++)
        {
            int[] arr = new int[c];
            for (int j = 0; j < c; j++)
            {
                arr[j] = dataList[listCounter++];
            }
            retMat[i] = arr;
        }

        return retMat;
    }
}
