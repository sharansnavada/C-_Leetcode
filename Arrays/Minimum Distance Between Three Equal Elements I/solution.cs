public class Solution {
    public int MinimumDistance(int[] nums) {
        int distance = int.MaxValue;

        for(int i = 0; i < nums.Length; i++){
            int[] indexArr = new int[2];
            int count = 0;
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] == nums[j]){
                    indexArr[count++] = j;
                }
                if(count == 2) break;
            }
            if(count < 2) continue;
            int sum = Math.Abs(i - indexArr[0]) + Math.Abs(indexArr[0] - indexArr[1]) + Math.Abs(indexArr[1] - i);
            if(sum < distance) distance = sum;
        }
        return distance == int.MaxValue ? -1 : distance;
    }
}
