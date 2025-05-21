public class Solution {
    public int Maximum69Number (int num) {
        int maxNumber = num;
        string s = maxNumber.ToString();
        

        for(int i = 0; i <= s.Length - 1; i++){
            StringBuilder strNum = new StringBuilder(s);
            if(strNum[i] == '6'){
                strNum[i] = '9';
            }
            else{
                strNum[i] = '6';
            }

            maxNumber = int.Parse(strNum.ToString()) > maxNumber ? int.Parse(strNum.ToString()) : maxNumber;
        }
        return maxNumber;
    }
}
