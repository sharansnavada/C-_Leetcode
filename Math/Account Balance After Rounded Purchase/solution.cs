public class Solution {
    public int AccountBalanceAfterPurchase(int purchaseAmount) {
        if(purchaseAmount == 0)
            return 100;
        else if(purchaseAmount == 100)
            return 0;
        else{
            int downNearest = purchaseAmount;
            int upNearest = purchaseAmount;
            
            while(downNearest % 10 != 0 && upNearest % 10 != 0){
                downNearest--;
                upNearest++;
            }
            
            if(upNearest % 10 == 0) purchaseAmount = upNearest;
            else purchaseAmount = downNearest;
        }

        return 100 - purchaseAmount;
    }
}

//return 100 - ((purchaseAmount + 5) / 10) * 10;
