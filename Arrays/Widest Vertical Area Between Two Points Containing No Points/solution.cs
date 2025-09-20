public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        int[] arr = new int[points.Length];
        int i = 0; bool firstOne = true;
        int wildestGap = -1;
        
        foreach(int[] arrs in points){
            foreach(int arrElement in arrs){
                if(firstOne){
                    arr[i++] = arrElement;
                }
                firstOne = !firstOne;
            }
        }

        Array.Sort(arr);

        for(int j = 1; j < arr.Length; j++){
            if(arr[j] - arr[j - 1] > wildestGap)    
                wildestGap = arr[j] - arr[j - 1];
        }

        return wildestGap;
    }
}
