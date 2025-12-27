public class Solution {
    public int HammingWeight(int n) {
        string binary = Convert.ToString(n, 2);
        int setBits = 0;

        foreach(char bits in binary){
            if(bits == '1')
                setBits++;
        }

        return setBits;
    }
}
