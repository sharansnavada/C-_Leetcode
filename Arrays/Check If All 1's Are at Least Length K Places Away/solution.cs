public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int distance = 0;
        bool gotFirstOne = false;

        foreach(int bit in nums){
            if(bit != 1 && !gotFirstOne)    
                continue;
            else if(bit == 1 && !gotFirstOne)   
                gotFirstOne = true;
            else{
                if(bit == 0)    
                    distance++;
                else{
                    if(distance < k)    
                        return false;
                    else    
                        distance = 0;
                }
            }
        }
        return true;
    }
}
