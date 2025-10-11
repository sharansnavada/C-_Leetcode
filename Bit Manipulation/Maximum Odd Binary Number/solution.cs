//that we can have all the 1's in the beginning except one 1 , 0's in the middle and one 1 at the end .
public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int totalOnes = s.Count(x => x == '1') - 1;
        char[] retArr = new char[s.Length];

        for(int i = 0; i < s.Length - 1; i++){
            if(totalOnes > 0){
                retArr[i] = '1';
                totalOnes = totalOnes - 1;
            }
            else{
                retArr[i] = '0';
            }
        }
        retArr[s.Length - 1] = '1';

        return new string(retArr);
    }
}
