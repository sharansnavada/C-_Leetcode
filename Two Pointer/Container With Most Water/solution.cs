public class Solution {
    public int MaxArea(int[] height) {
        int maxDistance = 0;
        int right = height.Length - 1;
        int left = 0;

        while(left < right){
            if(Math.Min(height[left], height[right]) * (right - left) > maxDistance){
                maxDistance = Math.Min(height[left], height[right]) * (right - left);
            }
            if(height[right] < height[left])
                right--;
            else
                left++;
        }
        return maxDistance;
    }
}
