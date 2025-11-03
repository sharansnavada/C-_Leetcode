//MinCost("aaabbbabbbb", new int[] {3,5,10,7,5,3,5,5,4,8,1});
//output - 26
public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int minTime = 0;
        char prevColor = colors[0];
        int subCount = 0;
        int maxTime = int.MinValue;

        for(int i = 1; i < colors.Length; i++){
            if(i == colors.Length - 1 && colors.Length > 1){
                if(colors[i - 1] == colors[i]){
                    subCount += neededTime[i];
                    maxTime = maxTime < neededTime[i] ? neededTime[i] : maxTime;
                    minTime += subCount - maxTime;
                    break;
                }
            }
            char currentColor = colors[i];
            if(currentColor == prevColor){
                subCount += neededTime[i - 1];
                maxTime = maxTime < neededTime[i - 1] ? neededTime[i - 1] : maxTime;
            }
            else{
                subCount += neededTime[i - 1];
                maxTime = maxTime < neededTime[i - 1] ? neededTime[i - 1] : maxTime;
                minTime += subCount - maxTime;
                subCount = 0; maxTime = int.MinValue;

            }
            if( i == colors.Length - 1 && prevColor == currentColor){

            }
            prevColor = currentColor;
        }

        return minTime;
    }
}
