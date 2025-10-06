public class Solution {
    public int GcdOfOddEvenSums(int n) {
        if(n == 1)
            return 1;
        int sumOdd = n * n;
        int sumEven = sumOdd - n; 
        int maxDivisor = Math.Min(sumOdd, sumEven);
        int gcd = 0;
        
        for(int i = 2; i <= maxDivisor; i++){
            if(sumOdd % i == 0 && sumEven % i == 0)
                gcd = i;
        }

        return gcd;
    }
}
