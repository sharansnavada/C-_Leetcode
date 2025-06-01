public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        int[] arr = new int[1001];
        List<int> result = new List<int>();

        foreach(int number in nums1){
            arr[number] += 1;
        }

        foreach(int number in nums2){
            if(arr[number] != 0){
                result.Add(number);
                arr[number] -= 1;
            }
        }

        return result.ToArray();
    }
}
