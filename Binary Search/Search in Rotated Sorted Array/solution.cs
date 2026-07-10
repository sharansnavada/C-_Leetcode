public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = 0;

        // Spiltting array into 2 and searching target in 
        // first array through BS. If not found in 1st then 
        // search in 2nd
        for(int i = 0; i < nums.Length - 1; i++){
            if(nums[i + 1] < nums[i]){
                right = i;
                break;
            }
        }

        int haveTarget = CustomBinarySearch(left, right, nums, target);
        
        if(haveTarget != -1) return haveTarget;
        else{
            left = right + 1;
            right = nums.Length - 1;
        }
        
        return CustomBinarySearch(left, right, nums, target);
    }

    int CustomBinarySearch(int left, int right, int[] nums, int target){
        while(left <= right){
            int mid = left + (right - left) / 2;

            if(nums[mid] == target) return mid;
            else if(nums[mid] > target) right = mid - 1;
            else if(nums[mid] < target) left = mid + 1;
        }
        return -1;
    }
}
