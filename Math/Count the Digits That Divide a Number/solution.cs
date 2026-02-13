public class Solution {
    public int CountDigits(int num) {
        int count = 0;
        string numStr = num.ToString();

        foreach(char number in numStr){
            if(num % (int.Parse(number.ToString())) == 0)
                count++;
        }
        return count;
    }
}
