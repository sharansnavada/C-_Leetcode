public class Solution {
    public int SmallestNumber(int n) {
        int currentBit = 0;
        string bits = Convert.ToString(n, 2); //to convert the decimal to binary
        StringBuilder sb = new StringBuilder();

        foreach(char bit in bits){
            sb.Append(bit == '0' ? '1' : bit);
        }
        bits = sb.ToString();

        foreach(char b in bits){
            currentBit = currentBit * 2 + int.Parse(b.ToString()); // to convert binary to decimal
        }

        return currentBit;
    }
}
