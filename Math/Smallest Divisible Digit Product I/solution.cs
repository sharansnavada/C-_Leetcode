public class Solution {
    public int SmallestNumber(int n, int t) {
        while(true){
            if(GetProduct(n) % t == 0){
                return n;
            }
            else n++;
        }
        return 0;
    }

    int GetProduct(int n){
        int prod = 1;
        while(n > 0){
            prod *= n % 10;
            n /= 10;
        }
        return prod;
    }
}
