public class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
        int newLine = 1;
        int sum = 0; int lastLine = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if(sum + widths[s[i] - 'a'] <= 100){
                sum += widths[s[i] - 'a'];
                lastLine = sum;
            }
            else{
                sum = widths[s[i] - 'a'];
                newLine++;
            }
        }
        return new int[2] { newLine, sum };
    }
}
