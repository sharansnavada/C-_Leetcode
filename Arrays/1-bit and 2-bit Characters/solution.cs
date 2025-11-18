public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int index = 0;
        bool is1Bit = true;

        while(index < bits.Length){
            if(bits[index] == 1){
                is1Bit = false;
                index = index + 2;
            }
            else{
                is1Bit = true;
                index++;
            }
        }
        return is1Bit;
    }
}
