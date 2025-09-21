public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] decRet = new int[encoded.Length + 1];
        decRet[0] = first;

        for(int i = 0; i < encoded.Length; i++){
            decRet[i + 1] = encoded[i] ^ decRet[i];
        }
        return decRet;
    }
}
