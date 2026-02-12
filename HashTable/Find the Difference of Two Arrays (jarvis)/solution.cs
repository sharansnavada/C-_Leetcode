public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {

        // range: -1000 to 1000 → shift by +1000
        int[] hashTable1 = new int[2001];
        int[] hashTable2 = new int[2001];

        foreach (int num in nums1) {
            hashTable1[num + 1000]++;
        }

        foreach (int num in nums2) {
            hashTable2[num + 1000]++;
        }

        List<int> l1 = new List<int>();
        List<int> l2 = new List<int>();

        HashSet<int> seen1 = new HashSet<int>();
        HashSet<int> seen2 = new HashSet<int>();

        foreach (int num in nums1) {
            int index = num + 1000;
            if (hashTable2[index] == 0 && seen1.Add(num)) {
                l1.Add(num);
            }
        }

        foreach (int num in nums2) {
            int index = num + 1000;
            if (hashTable1[index] == 0 && seen2.Add(num)) {
                l2.Add(num);
            }
        }

        return new List<IList<int>> { l1, l2 };
    }
}
