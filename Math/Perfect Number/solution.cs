public class Solution {
    public bool CheckPerfectNumber(int num) {
        List<int> n = new List<int>();
        for(int i = 1 ; i <= (num/2); i++){
            if(num % i == 0){
                n.Add(i);
            }
        }
        int sum = n.Sum(x => x);
        if(num - sum == 0){
            return true;
        }else{
            return false;
        }
    }
}
