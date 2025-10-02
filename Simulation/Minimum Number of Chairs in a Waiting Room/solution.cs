public class Solution {
    public int MinimumChairs(string s) {
        int high = int.MinValue;
        int sum = 0;

        foreach(char letter in s){
            if(letter == 'E'){
                sum++;
                high = Math.Max(high, sum);
            }
            else{
                sum--;
            }
        }
        return high;
    }
}
