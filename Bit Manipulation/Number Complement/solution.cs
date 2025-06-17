//optimozed solution
// public class Solution {
//     public int FindComplement(int num) {
//         // Step 1: Create a mask with all bits set to 1 of the same length as num
//         int mask = 0;
//         int temp = num;
        
//         while (temp != 0) {
//             mask = (mask << 1) | 1;
//             temp >>= 1;
//         }

//         // Step 2: XOR the number with the mask to flip the bits
//         return num ^ mask;
//     }
// }
//my solution ------------->

public class Solution {
    public int FindComplement(int num) {
        int pow = 0;
            int n = num;
            StringBuilder sb = new StringBuilder();
            int retComplement = 0;
            while(Math.Pow(2,pow) < num)
            {
                pow++;
            }

            for(int i = pow; i >= 0; i--)
            {
                if(num >= Math.Pow(2, i))
                {
                    if (n >= Math.Pow(2, i))
                    {
                        sb.Append("0");
                        n -= (int)Math.Pow(2, i);
                    }
                    else
                    {
                        sb.Append("1");
                    }
                }
            }

            pow = 0;
            for(int i = sb.Length - 1; i >= 0; i--)
            {
                if(sb[i] != '0')
                {
                    retComplement += (int)Math.Pow(2, pow/*int.Parse(sb[i].ToString())*/);
                }
                pow++;
            }

            return retComplement;
    }
}
