public class Solution {
    public int ClimbStairs(int n) {
        int first = 1;
        if( n == 1){
            return first;
        }
        int second = 2;
        for(int i = 2 ; i < n; i++){
            int third = first + second;
            first = second;
            second = third;
        }
        return second;
    }
}
