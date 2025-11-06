public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] retArr = new int[nums1.Length];
        int[] hashTable = new int[100002];
        bool hasGot = false;

        for(int i = 0; i < nums1.Length; i++){
            hasGot = false;
            for(int j = 0; j < nums2.Length; j++){
                if(nums1[i] == nums2[j]){
                    for(int k = j + 1; k < nums2.Length; j++){
                        if(nums2[k] > nums2[j]){
                            hashTable[nums2[j]] = nums2[k];
                            hasGot = true;
                            break;
                        }
                    }
                }
                if(hasGot){
                    break;
                }
            }
        }

        for(int l = 0; l < nums1.Length; l++){
            retArr[l] = hashTable[nums1[l]];
        }
        return retArr;
    }
}
