public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int rightPointer = 0;
        int leftPointer = 0;

        while (rightPointer < nums1.Length && leftPointer < nums2.Length){
            if (nums1[rightPointer] == nums2[leftPointer]) return nums1[rightPointer];
            else if (nums1[rightPointer] < nums2[leftPointer]) rightPointer++;
            else if (nums1[rightPointer] > nums2[leftPointer]) leftPointer++;
        }
        return -1;
    }
}
