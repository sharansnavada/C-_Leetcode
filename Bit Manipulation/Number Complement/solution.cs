public class Solution {
    public int FindComplement(int num) {
        // Step 1: Create a mask with all bits set to 1 of the same length as num
        int mask = 0;
        int temp = num;
        
        while (temp != 0) {
            mask = (mask << 1) | 1;
            temp >>= 1;
        }

        // Step 2: XOR the number with the mask to flip the bits
        return num ^ mask;
    }
}
