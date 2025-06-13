public class Solution {
    public void ReverseString(char[] s) {
        int i = 0;
        int j = s.Length - 1;
        char temp = ' ';

        if(j + 1 == 0){
            return;
        }

        while(i <= j){
            temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            i++;
            j--;
        }
    }
    
}
