public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        for(int i = m ; i < nums1.Length ; i++){
            nums1[i] = nums2[nums2.Length - n];
            n--;
        }
        Array.Sort(nums1);
    }
}
