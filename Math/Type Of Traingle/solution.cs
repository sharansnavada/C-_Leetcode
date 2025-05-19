public class Solution {
    public string TriangleType(int[] nums) {
        if (nums[0] == nums[1] && nums[1] == nums[2]) {
            return "equilateral";
        }
        if(nums[0] + nums[1] > nums[2] && nums[0] + nums[2] > nums[1] && nums[1] + nums[2] > nums[0]){
            if(((float)nums[0]/nums[2]) == 1f|| ((float)nums[0]/nums[1]) == 1f || ((float)nums[1]/nums[2]) == 1f)
                return "isosceles";
        }
        
        if(nums[0] + nums[1] > nums[2] && nums[0] + nums[2] > nums[1] && nums[1] + nums[2] > nums[0]){
            return "scalene";
        }

        return "none";
    }
}
