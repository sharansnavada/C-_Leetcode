public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] retArr = new int[nums1.Length];
        int[] hashTable = new int[100002];

        for (int i = 0; i < hashTable.Length; i++) {
            hashTable[i] = -1;
        }

        for (int i = 0; i < nums2.Length; i++) {
            for (int j = i + 1; j < nums2.Length; j++) {
                if (nums2[j] > nums2[i]) {
                    hashTable[nums2[i]] = nums2[j];
                    break;
                }
            }
        }

        for (int l = 0; l < nums1.Length; l++) {
            retArr[l] = hashTable[nums1[l]];
        }

        return retArr;
    }
}
