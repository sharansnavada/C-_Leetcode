public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int start = 0;
        int end = nums.Length -1;
        int count = 0;
        bool isAllSame = false;
        bool hasChanged = false;
        
        if(nums.Length == 0){
            nums = new int[0];
            return 0;
        }
        if(nums.Length == 1){
            if(val == nums[0]){
                nums = new int[0];
                return 0;
            }
            else {
                return 1;
            }
        }
        while(start < end){
            if(nums[start] == val){
                if(nums[start] != nums[end]){
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                end--;start++;count++;
                isAllSame = false;
                hasChanged = true;
                }
                else{
                    end--;count++;
                    isAllSame = true;
                }
            }
            else{
                start++;count++;
                isAllSame = false;
                 }
        }
        if(isAllSame){
            nums = new int[0];
            return 0;
        }
        else{
            if(hasChanged){
                return count;
            }
            else{
                return count + 1;
            }
        }
    }
}
