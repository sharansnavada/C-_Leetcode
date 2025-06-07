public class Solution {
    public int ArrangeCoins(int n) {
        int m = n;
        int i = 1;

        while(true){
            m = m - i;
            if(!(m >= (i+1))){
                return i;
            }
            i++;
        }
        return 0;
    }
}

// Optimized solution using Binary Search algorithm

public class Solution {
    public int ArrangeCoins(int n) {
        int l = 0;
        int r=n;
        
        while(l<=r){
            long mid = l+(r-l)/2;
            if(n>=(mid*(mid+1)/2)){
                l=(int)(mid+1);
            }else{
                r=(int)(mid-1);
            }
         }
         return l-1;
       
    }
}
