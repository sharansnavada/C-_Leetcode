using System.Numerics;

public class Solution {
    public int[] PlusOne(int[] digits) {
        string strNum = "";
        foreach(int i in digits){
            strNum += i.ToString();
        }

        //int num = int.Parse(strNum);
        BigInteger bg = BigInteger.Parse(strNum);
        //num = num + 1;
        bg = bg + 1;
        strNum = bg.ToString();
        int[] arr = new int[strNum.Length];
        int j = 0;
        foreach(char c in strNum){
            arr[j] = int.Parse(c.ToString());
            j++;
        }
        return arr;
    }
}
