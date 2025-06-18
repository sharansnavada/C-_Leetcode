public class Solution {
    public int HammingDistance(int x, int y) {
            int pow = 0;
            int counter = 0;
            // swap if y is greater than x
            if(x < y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            //calculating the power for 2 to get the x
            while(Math.Pow(2,pow) <= x)
            {
                pow++;
            }

            int[] xArr = new int[pow + 1];
            int[] yArr = new int[pow + 1];

            int tempX = x;
            int tempY = y;

            for(int i = pow; i >= 0; i--)
            {
                //calculating the bits for x
                if(x >= Math.Pow(2, i))
                {
                    if(tempX >= Math.Pow(2, i))
                    {
                        xArr[i] = 1;
                        tempX -= (int)Math.Pow(2, i);
                    }
                }
                //calculating the bits for y
                if (y >= Math.Pow(2, i))
                {
                    if (tempY >= Math.Pow(2, i))
                    {
                        yArr[i] = 1;
                        tempY -= (int)Math.Pow(2, i);
                    }
                }
                //the binary form is in the reverse order as we have started from the most significant bit. 
                //if corresponding bit are different increment the counter
                if ((xArr[i] ^ yArr[i]) == 1)
                {
                    counter++;
                }
            }

            return counter;
    }
}
