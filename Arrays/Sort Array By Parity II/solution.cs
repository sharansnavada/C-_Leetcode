public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int n = nums.Length;
        int[] retArr = new int[n];
        int[] oddArr = new int[n / 2];
        int[] evenArr = new int[n / 2];
        int oddIndex = 0; int evenIndex = 0;

        foreach(int number in nums){
            if(number % 2 == 0)
                evenArr[evenIndex++] = number;
            else
                oddArr[oddIndex++] = number;
        }

        oddIndex = 0; evenIndex = 0;
        bool isEvenIndex = true;

        for(int i = 0; i < n; i++){
            if(isEvenIndex){
                retArr[i] = evenArr[evenIndex++];
                isEvenIndex = !isEvenIndex;
            }
            else{
                retArr[i] = oddArr[oddIndex++];
                isEvenIndex = !isEvenIndex;
            }
        }
        
        return retArr;
    }
}
