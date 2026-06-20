public class Solution {
    public int LargestAltitude(int[] gain) {
        int max = 0;//int.MinValue;
        int sum = 0;

        foreach(int alt in gain){
            sum += alt;
            max = sum > max ? sum : max; 
        }
        return max;
    }
}
