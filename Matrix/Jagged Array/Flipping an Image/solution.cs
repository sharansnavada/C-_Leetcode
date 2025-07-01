public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int[][] flippedNInverted = new int[image.Length][];

        for(int i = 0; i < image.Length; i++){
            int counter = 0;
            int[] newArr = new int[image[i].Length]; //new array for storing reversed inverted elements
            for(int j = image[i].Length - 1; j >= 0; j--){ //we'll start from last elemet of the first array in jagged arrays and so on
                newArr[counter++] = image[i][j] == 0 ? 1 : 0;
            }
            flippedNInverted[i] = newArr;
        }

        return flippedNInverted;
    }
}
