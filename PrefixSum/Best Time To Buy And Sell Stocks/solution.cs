        // int maxProfit = 0;

        // for(int i = 0;i <= prices.Length - 1; i++){
        //     for(int j = i + 1; j <= prices.Length - 1;j++){
        //         int sum = prices[j] - prices[i];
        //         if(sum > maxProfit){
        //             maxProfit = sum;
        //         }
        //     }
        // }
        // return maxProfit;

        //Commenting above code as it takes O(n * n)
        
    public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices) {
            if (price < minPrice) {
                minPrice = price;
            } else {
                int profit = price - minPrice;
                if (profit > maxProfit) {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}
