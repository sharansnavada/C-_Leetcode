public class Solution {
    public int AddDigits(int num) {
        while(num >= 10){
            string str = num.ToString();
            int n = 0;
            foreach(char number in str){
                n += int.Parse(number.ToString());
            }
            num = n;
        }
        return num;
    }
}
