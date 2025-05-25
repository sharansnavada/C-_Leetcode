public class Solution {
    public int[] CountBits(int n) {
        int[] arr = new int[n + 1];
        if(n == 0){
            return new int[]{0};
        }
        else if(n == 1){
            return new int[]{0,1};
        }
        else{
            arr[0] = 0;
            arr[1] = 1;
            int i = 2;

            while(i <= n){
                int numerator = 0;
                int number = i;
                int totalOnes = 0;
              
                while(numerator != 1){
                    numerator = number / 2;
                    totalOnes += number % 2;
                    number = numerator;
                }
              
                arr[i] = totalOnes + numerator;
                i++;
            }
        }
        return arr;
    }
}
