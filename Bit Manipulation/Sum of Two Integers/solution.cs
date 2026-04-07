public class Solution {
    public int GetSum(int a, int b) {
        string binaryA = Convert.ToString(a, 2);
        string binaryB = Convert.ToString(b, 2);
        StringBuilder sb = new StringBuilder();
        int bit = 0;
        int carry = 0;

        if(binaryA.Length > binaryB.Length) binaryB = binaryB.PadLeft(binaryA.Length, '0');
        else if(binaryB.Length > binaryA.Length) binaryA = binaryA.PadLeft(binaryB.Length, '0');

        for(int i = binaryA.Length - 1; i >= 0; i--){
            if(carry == 0)
            {
                if((int.Parse(binaryA[i].ToString()) ^ int.Parse(binaryB[i].ToString())) == 1)
                    sb.Insert(0, 1);
                else if((int.Parse(binaryA[i].ToString()) ^ int.Parse(binaryB[i].ToString())) == 0 && (binaryA[i] == '1' || binaryB[i] == '1'))
                {
                    sb.Insert(0, 0);
                    carry = 1;
                }
                else    
                    sb.Insert(0, 0);   
            }
            else
            {
                if((int.Parse(binaryA[i].ToString()) ^ int.Parse(binaryB[i].ToString())) == 1)
                {
                    sb.Insert(0, 0);
                    carry = 1;
                }
                else if((int.Parse(binaryA[i].ToString()) ^ int.Parse(binaryB[i].ToString())) == 0 && (binaryA[i] == '1' || binaryB[i] == '1'))
                {
                    sb.Insert(0, 1);
                    carry = 1;
                }
                else
                {
                    sb.Insert(0, 1);
                    carry = 0;
                }
            }
        }

        if(carry == 1) sb.Insert(0, 1);

        foreach(char bits in sb.ToString())
        {
            bit = bit * 2 + int.Parse(bits.ToString());
        }
        return bit;
    }
}
