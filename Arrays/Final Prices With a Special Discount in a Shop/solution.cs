public class Solution {
    public int[] FinalPrices(int[] prices) {
        int[] discountedArr = new int[prices.Length];

        for(int i = 0; i < prices.Length; i++){
            bool gotDiscount = false;
            for(int j = i + 1; j < prices.Length; j++){
                if(prices[i] >= prices[j]){
                    discountedArr[i] = prices[i] - prices[j];
                    gotDiscount = true;
                    break;
                }
            }
            if(!gotDiscount){
                discountedArr[i] = prices[i];
            }
        }
        return discountedArr;
    }
}
