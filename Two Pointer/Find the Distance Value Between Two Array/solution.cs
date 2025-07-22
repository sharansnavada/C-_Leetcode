public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        int distinct = 0; bool countThis = true;
        
        foreach(int num1 in arr1){
            foreach(int num2 in arr2){
                if(Math.Abs(num1 - num2) <= d)
                    countThis = false;
            }
            if(countThis)
                distinct++;
            countThis = true;
        }
        return distinct;
    }
}
