public class Solution {
    public int DiagonalSum(int[][] mat) {
        int fromLeft = 0;
        int fromRight = mat.Length - 1;
        int sum = 0;
        
        while(fromLeft < mat.Length && fromRight >= 0){
            if(fromLeft == fromRight) //if the row's length is odd number, then I'm preventing middle number to be added twice 
                sum += mat[fromLeft][fromLeft]; 
            else{
                sum += mat[fromLeft][fromLeft] + mat[fromLeft][fromRight];
            }
            fromLeft++; fromRight--;
        }
        return sum;
    }
}
