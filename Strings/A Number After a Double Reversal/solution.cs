public class Solution {
    public bool IsSameAfterReversals(int num) {
        StringBuilder sb = new StringBuilder();
        string numStr = num.ToString();
        bool gotNonZero = false;

        for(int i = numStr.Length - 1; i >= 0; i--){
            if(!gotNonZero){
                if(numStr[i] == '0') continue;
                else{
                    gotNonZero = true;
                    sb.Append(numStr[i]);
                }
            }
            else{
                sb.Append(numStr[i]);
            }
        }

        if(sb.ToString() == "") sb.Append('0');

        StringBuilder sb1 = new StringBuilder();
        gotNonZero = false;
        for(int i = sb.Length - 1; i >= 0; i--){
            if(!gotNonZero){
                if(sb[i] == '0') continue;
                else{
                    gotNonZero = true;
                    sb1.Append(sb[i]);
                }
            }
            else{
                sb1.Append(sb[i]);
            }
        }

        if(sb1.ToString() == "") sb1.Append('0');
        
        return sb1.ToString() == num.ToString();
    }
}
