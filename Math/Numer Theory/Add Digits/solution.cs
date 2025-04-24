public class Solution {
    public int AddDigits(int num) {
        // int sum = 0;
        // while (num.ToString().Length != 1){
        //     foreach(char s in num.ToString()){
        //         sum = sum + int.Parse(s.ToString());

        //     }
        //     num = sum;
        //     sum = 0;
        // }
        // return num;
    if (num == 0) return 0;
    return 1 + (num - 1) % 9;
    }

}
