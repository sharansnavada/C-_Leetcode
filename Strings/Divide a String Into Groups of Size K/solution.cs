public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        int size = (int)Math.Ceiling((double)s.Length / k);
        string[] retArr = new string[size];
        int retArrCounter = 0;
        int totalCounter = 0;
        int internalCounter = 0;
        string str = "";

        while(totalCounter != s.Length){
            if(str.Length != k){
                str += s[totalCounter++];
            }
            else{
                retArr[retArrCounter++] = str;
                str = "";
            }
        }

        retArr[retArrCounter++] = str;

        str = retArr[retArr.Length - 1];
        if(str.Length != k){
            for(int i = str.Length; i < k; i++){
                str += fill.ToString();
            }
            retArr[retArr.Length - 1] = str;
        }

        return retArr;
    }
}
