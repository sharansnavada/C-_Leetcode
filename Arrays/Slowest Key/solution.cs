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