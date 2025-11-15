public class Solution {
    public int GetLucky(string s, int k) {
        string asciiConcat = "";
        int sum = 0;

        foreach(char letter in s){
            asciiConcat += (letter - 'a' + 1).ToString();
        }

        while(k != 0){
            sum = 0;
            foreach(char number in asciiConcat){
                sum += int.Parse(number.ToString());
            }
            asciiConcat = sum.ToString();
            k--;
        }
        return sum;
    }
}
