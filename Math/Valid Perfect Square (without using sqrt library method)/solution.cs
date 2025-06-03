//This problem can be fully optimized if I use Binary Search algoritm
//In future I'll try by doing using BS algo and will checkin that code
public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num == 1){
            return true;
        }
        for(int i = 0; i <= num/2; i++){
            if(i * i == num){
                return true;
            }
            else if(i * i > num){
                break;
            }
        }
        return false;
    }
}
