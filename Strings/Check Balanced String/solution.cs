public class Solution {
    public bool IsBalanced(string num) {
       int evenSum = 0, oddSum = 0;
       bool isEven = true;
       int n = num.Length;

       for(int i = 0; i < n; i++){
            if(isEven){
                evenSum += int.Parse(num[i].ToString());
                isEven = false;
            }
            else{
                oddSum += int.Parse(num[i].ToString());
                isEven = true;
            }
       }

       return evenSum == oddSum; 
    }
}
