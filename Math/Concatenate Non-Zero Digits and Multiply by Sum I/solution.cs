public class Solution {
    public long SumAndMultiply(int n) {
        long x = 0;
        long multiplier = 1;
        long sum = 0;

        while(n > 0){
            long msb = n % 10;
            n = n / 10;

            if(msb != 0){
                sum = sum + msb;
                x = x + (msb * multiplier);
                multiplier = multiplier * 10;
            }
        }
        return x * sum;

    }
}
