// Below code is done using Intersect method
// public class Solution {
//     public int[] Intersection(int[] nums1, int[] nums2) {
//         int[] uniqueElements = nums1.Intersect(nums2).ToArray();
//         return uniqueElements;

//     }
// }
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
       int[] frequency = new int[1001];
       List<int> answer = new List<int>();

       for(int i=0; i<nums1.Length;i++){
            frequency[nums1[i]]++;
       }

       for(int j=0; j<nums2.Length;j++){
            if(frequency[nums2[j]] != 0){
                answer.Add(nums2[j]);
                frequency[nums2[j]] = 0;
            }
       }

       return answer.ToArray();
    }
}
