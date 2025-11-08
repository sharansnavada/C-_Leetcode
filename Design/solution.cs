public class Bank {

    int numberOfAccounts = 0;
    long[] balance;

    public Bank(long[] balance) {
        numberOfAccounts = balance.Length;
        this.balance = balance;
    }
    
    public bool Transfer(int account1, int account2, long money) {
        if((account1 > 0 && account1 <= numberOfAccounts) && (account2 > 0 && account2 <= numberOfAccounts)){
            if(balance[account1 - 1] >= money){
                balance[account1 - 1] -= money;
                balance[account2 - 1] += money;
                return true;
            }
            else
                return false;
            
        }
        return false;
    }
    
    public bool Deposit(int account, long money) {
        if(account > 0 && account <= numberOfAccounts){
            balance[account - 1] += money;
            return true;
        }
        return false;
    }
    
    public bool Withdraw(int account, long money) {
        if(account > 0 && account <= numberOfAccounts){
            if(balance[account - 1] >= money){
                balance[account - 1] -= money;
                return true;
            }
            
        }
        return false;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */