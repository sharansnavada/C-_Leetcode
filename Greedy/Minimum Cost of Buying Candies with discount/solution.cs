public class Solution {
    public int MinimumCost(int[] cost) {
        Array.Sort(cost);
        int count = 0;
        int index = cost.Length - 1;
        bool isFirstCandy = true;
        bool isSecondCandy = false;
        bool isFreeCandy = false;

        while(index >= 0){
            if(isFirstCandy){
                isFirstCandy = false;
                count += cost[index];
                isSecondCandy = true;
            }
            else if(isSecondCandy){
                isSecondCandy = false;
                count += cost[index];
                isFreeCandy = true;
            }
            else if(isFreeCandy){
                isFreeCandy = false;
                isFirstCandy = true;
            }
            index--;
        }
        return count;
    }
}
