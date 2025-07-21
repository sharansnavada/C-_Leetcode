public class Solution {
    public string ThousandSeparator(int n) {
        int counter = 0;
        StringBuilder sb = new StringBuilder();
        string strNumber = n.ToString();
        for(int i = strNumber.Length - 1; i > -1; i--){
            if(counter == 3){
                sb.Insert(0,".");
                counter = 0;
                i++;
                continue;
            }
            sb.Insert(0,strNumber[i].ToString());
            counter++;
        }
        return sb.ToString();
    }
}
