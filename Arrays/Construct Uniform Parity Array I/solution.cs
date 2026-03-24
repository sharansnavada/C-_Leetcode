public class Solution {
    public bool UniformArray(int[] nums1) {
        if(nums1.Length == 1) return true;

        List<int> bucket = new List<int>();
        int[] nums2 = new int[nums1.Length];
        bool isOdd = false; bool isEven = false;

        for(int i = 0; i < nums1.Length; i++){
            isOdd = false;
            for(int j = 0; j < nums1.Length; j++){
                if(nums1[i] % 2 != 0 && !bucket.Contains(nums1[i])){
                    bucket.Add(nums1[i] - nums1[j]);
                    isOdd = true; break;
                }
                if(i != j){
                    if(nums1[i] - nums1[j] % 2 != 0 && !bucket.Contains(nums1[i] - nums1[j])){
                        bucket.Add(nums1[i] - nums1[j]);
                        isOdd = true; break;
                    }
                }
            }
            if(!isOdd) break;
        }

        if(isOdd) return true;
        bucket = new List<int>(); // if we already got odd array, return ture, no need of checking for even array

        for(int i = 0; i < nums1.Length; i++){
            isEven = false;
            for(int j = 0; j < nums1.Length; j++){
                if(nums1[i] % 2 == 0 && !bucket.Contains(nums1[i])){
                    bucket.Add(nums1[i] - nums1[j]);
                    isEven = true; break;
                }
                if(i != j){
                    if(nums1[i] - nums1[j] % 2 == 0 && !bucket.Contains(nums1[i] - nums1[j])){
                        bucket.Add(nums1[i] - nums1[j]);
                        isEven = true; break;
                    }
                }
            }
            if(!isEven) break;
        }

        if(isEven) return true;

        return false;
    }
}
