public class Solution {
    public int SubtractProductAndSum(int n) {
        string strNum = n.ToString();
        int prod = 1;
        int sum = 0;

        foreach(char number in strNum){
            prod *= int.Parse(number.ToString());
            sum += int.Parse(number.ToString());
        }

        return prod - sum;
    }
}
