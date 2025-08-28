using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Class3
    {
        public static void printpattern(int n)
        {
            int startingNumber = 1;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < n; i++)
            {
                int space = i;
                for(int j = 0; j < (n - i); j++)
                {
                    while(space != 0)
                    {
                        sb.Append("  ");
                        space--;
                    }
                    sb.Append(startingNumber >= 10 ? startingNumber + "  " : "0" + startingNumber + "  ");
                }
                Console.WriteLine(sb);
                sb = new StringBuilder();
                startingNumber++;
            }
        }
    }
}

public class Solution {
    public char SlowestKey(int[] releaseTimes, string keysPressed) {
        int longestReleaseTime = releaseTimes[0];
        char longestReleaseTimeKey = keysPressed[0];

        for(int i = 1; i < releaseTimes.Length; i++){
            int currentCalc = releaseTimes[i] - releaseTimes[i -1];
            if(currentCalc > longestReleaseTime){
                longestReleaseTime = currentCalc;
                longestReleaseTimeKey = keysPressed[i];
            }
            else if(currentCalc == longestReleaseTime){
                if((keysPressed[i] - 'a') > (longestReleaseTimeKey - 'a')){
                    longestReleaseTime = currentCalc;
                    longestReleaseTimeKey = keysPressed[i];
                }
            }
        }
        return longestReleaseTimeKey;
    }
}
