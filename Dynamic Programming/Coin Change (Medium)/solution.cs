public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // int[] minChangeTable = new int[amount + 1];
        // minChangeTable[0] = 0;

        // for(int i = 1; i <= amount; i++){
        //     int minChange = int.MaxValue;
        //     foreach(int currency in coins){
        //         int remaining = i - currency;
        //         if(remaining >= 0)
        //         {
        //             remaining = minChangeTable[remaining] + 1;
        //             if(remaining < minChange) minChange = remaining;
        //         } 
                
        //     }
        //     minChangeTable[i] = minChange;
        // }
        // return minChangeTable[amount];
        int[] minChangeTable = new int[amount + 1];
    Array.Fill(minChangeTable, int.MaxValue); // Initialize all to max
    minChangeTable[0] = 0;

    for (int i = 1; i <= amount; i++) {
        foreach (int coin in coins) {
            if (coin <= i && minChangeTable[i - coin] != int.MaxValue) {
                minChangeTable[i] = Math.Min(minChangeTable[i], minChangeTable[i - coin] + 1);
            }
        }
    }
    return minChangeTable[amount] == int.MaxValue ? -1 : minChangeTable[amount];
    }
}
