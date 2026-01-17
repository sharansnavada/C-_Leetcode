public class Solution {
    public bool IsArraySpecial(int[] nums) {
        bool isFirstEven = nums[0] % 2 == 0;
        bool isFirstOdd = nums[0] % 2 != 0;

        if(isFirstEven){
            bool even = true;
            for(int i = 0; i < nums.Length; i++){
                if(even){
                    if(nums[i] % 2 == 0){
                        even = !even;
                    }
                    else
                        return false;
                }
                else if(!even){
                    if(nums[i] % 2 != 0){
                        even = !even;
                    }
                    else{
                        return false;
                    }
                }
            }
        }

        if(isFirstOdd){
            bool odd = true;
            for(int i = 0; i < nums.Length; i++){
                if(odd){
                    if(nums[i] % 2 != 0){
                        odd = !odd;
                    }
                    else
                        return false;
                }
                else if(!odd){
                    if(nums[i] % 2 == 0){
                        odd = !odd;
                    }
                    else{
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
