public class Solution {
    public int[] SumAndMultiply(string s, int[][] queries) {
        int[] retArr = new int[queries.Length];
        int index = 0;
       
        foreach(int[] numArr in queries){
            int startIndex = numArr[0]; int endIndex = numArr[1];
            StringBuilder sb = new StringBuilder();
            int sum = 0;
            for(int i = startIndex; i <= endIndex; i++){
                if(s[i] != '0') sb.Append(s[i]);
                sum += int.Parse(s[i].ToString());
            }
            if(sb.Length == 0) sb.Append("0");
            long sbNum = long.Parse(sb.ToString());
            long output = sbNum * sum;
            const long MOD = 1000000007;
            retArr[index++] = (int)(output % MOD);
 
        }
        return retArr;
    }
}
