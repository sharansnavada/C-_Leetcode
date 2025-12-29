public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int sum = 0;
        string number = x.ToString();

        foreach(char num in number){
            sum += int.Parse(num.ToString());
        }

        if(x % sum == 0)
            return sum;
        return -1;
    }
}
