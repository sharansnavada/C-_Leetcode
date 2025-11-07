public class Solution {
    public int ReverseBits(int n) {
        string bits = Convert.ToString(n, 2).PadLeft(32,'0'); //Pad.Left is what i learnt today, 32 is the total number of length this string should be and '0' is to add to the left
        
        char[] charArray = bits.ToCharArray();
        Array.Reverse(charArray);
        string reverseBits = new string(charArray);

        int bit = 0;

        foreach(char b in reverseBits){
            bit = bit * 2 + int.Parse(b.ToString()); 
        }

        return bit;
    }
}
