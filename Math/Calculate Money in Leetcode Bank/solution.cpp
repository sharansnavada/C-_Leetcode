class Solution {
public:
    int totalMoney(int n) {
        int totalCount = 0;
        int incrementalDeposit = 1;
        int weekStartCount = 1;

        for(int i = 1; i <= n; i++){
            totalCount += incrementalDeposit;
            incrementalDeposit++;

            if(i % 7 == 0){ //if its sunday, then week is over, so assign incremented weekstartCount to incremental deposit
                incrementalDeposit = weekStartCount + 1;
                weekStartCount++;
            }
        }
        return totalCount;

    }
};
