//Simple and fully optimized code
public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
         List<int> result = new List<int>();
        int i = num.Length - 1;

        while (i >= 0 || k > 0) {
            if (i >= 0) {
                k += num[i];
                i--;
            }
            result.Add(k % 10);  // Add current digit
            k /= 10;             // Carry over
        }

        result.Reverse();  // Because we built the number from the back
        return result;
    }
}
