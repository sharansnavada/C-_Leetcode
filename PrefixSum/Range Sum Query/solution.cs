//This is the most optimized solution submitted by some leetcode user
public class NumArray {

    public int[] prefix;
    public NumArray(int[] nums) {
        prefix= new int[nums.Length+1];
        for(int i=0; i< nums.Length; i++){
            prefix[i+1]=prefix[i]+nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        var sum=prefix[right+1]-prefix[left];        
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */

//This is my O(N) time complexity and O(N) spce complexity
public class NumArray {
    int[] num = new int[10000];
    public NumArray(int[] nums) {
        num = nums;
    }
    
    public int SumRange(int left, int right) {
        int sum = 0;
        for(int i = left; i <= right; i++){
            sum += num[i];
        }

        return sum;
    }
}
