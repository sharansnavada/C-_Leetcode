public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int initialMoney = money;
        int index = 0;
        int haveToBuy = 2;
        while(haveToBuy > 0){
            int cheaperPrice = int.MaxValue;
            for(int i = 0; i < prices.Length; i++){
                if(prices[i] < cheaperPrice){
                     cheaperPrice = prices[i];
                     index = i;
                }
            }
            if((money - cheaperPrice) < 0)
                return initialMoney;
            else{
                money -= cheaperPrice;
                prices[index] = int.MaxValue;
            }
            haveToBuy--;
        }
        return money;
    }
}
