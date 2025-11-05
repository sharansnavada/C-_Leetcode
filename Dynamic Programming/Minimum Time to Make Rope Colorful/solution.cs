//MinCost("aaabbbabbbb", new int[] {3,5,10,7,5,3,5,5,4,8,1});
//output - 26
//MinCost("aabaa", new int[] {1,2,3,4,1});
//output - 2
public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        if (colors.Length == 1)
            return 0;
        int minTime = 0;
        char prevColor = colors[0];
        int subCount = 0;
        int maxTime = int.MinValue;

        for(int i = 1; i <= colors.Length; i++){
            if (i == colors.Length && colors.Length > 1)
            {
                if (colors[i - 1] == colors[i - 2])
                {
                    subCount += neededTime[i - 1];
                    maxTime = maxTime < neededTime[i - 1] ? neededTime[i - 1] : maxTime;
                    minTime += subCount - maxTime;
                    break;
                }
                else
                    break;
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

            prevColor = currentColor;
        }

        return minTime;
    }
}
