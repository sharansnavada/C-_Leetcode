public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int goodTripletsCount = 0;
        for(int i = 0; i < arr.Length - 2; i++){
            for(int j = i + 1; j < arr.Length - 1; j++){
                for(int k = j + 1; k < arr.Length; k++){
                    if((Math.Abs(arr[i] - arr[j]) <= a) && (Math.Abs(arr[j] - arr[k]) <= b) && (Math.Abs(arr[i] - arr[k]) <= c)){
                        goodTripletsCount++;
                    }
                }
            }
        }
        return goodTripletsCount;
    }
}
