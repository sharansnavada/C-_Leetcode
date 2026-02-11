public class Solution {
    public int CommonFactors(int a, int b) {
        int count = 0;
        int n = a > b ? a : b;

        for(int i = 1; i <= n; i++){
            if((a % i) == 0 && (b % i) == 0)
                count++;
        }
        return count;
    }
}
