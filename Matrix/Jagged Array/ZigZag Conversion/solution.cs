public class Solution {
    public string Convert(string s, int numRows) {
        int n = s.Length;
        char[][] arr = new char[numRows][];
        for(int i = 0; i < numRows; i++) {
            arr[i] = new char[1000];
        }
        int row = 0; int col = 0; int strIndex = 0;
        bool startZigZag = false;
        StringBuilder sb = new StringBuilder();

        while(n != 0){
            arr[row][col] = s[strIndex];

            if(row == numRows - 1) startZigZag = true;
            if(row == 0) startZigZag = false;
            
            if(numRows == 1) col++;
            else if(startZigZag){
                row--; col++;
            }
            else row++;

            n--; strIndex++;
        }

        foreach(char[] array in arr){
            foreach(char letter in array){
                if(letter != '\0')
                {
                    sb.Append(letter);
                }
            }
        }

        return sb.ToString();
    }
}
