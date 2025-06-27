public class Solution {
    public bool HasAlternatingBits(int n) {
        int pow = 0;
            int num = n;
            int lastNum = 0;
            int currentNumber = 0;
            while(Math.Pow(2,pow) < n)
            {
                pow++;
            }

            for(int i = pow; i >= 0; i--)
            {
                if(n >= Math.Pow(2, i))
                {
                    if (num >= Math.Pow(2, i))
                    {
                        lastNum = currentNumber;
                        currentNumber = 1;
                        num -= (int)Math.Pow(2, i);
                    }
                    else
                    {
                        lastNum = currentNumber;
                        currentNumber = 0;
                    }
                }
                if(i != pow){
                    if(currentNumber == lastNum){
                        return false;
                    }
                }
            }

            return true;
    }
}
