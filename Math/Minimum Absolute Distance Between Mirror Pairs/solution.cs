public class Solution {
    public int MinMirrorPairDistance(int[] nums) {
        int n = nums.Length;
        int ans = n + 1;
        var pos = new Dictionary<int, int>();

        for (int i = 0; i < n; i++) {
            int v = nums[i];

            if (pos.TryGetValue(v, out int j))
                ans = Math.Min(ans, i - j);

            int rev = Reverse(v);
            // Always overwrite: latest index = closest future right endpoint
            pos[rev] = i;
        }

        return ans > n ? -1 : ans;
    }

    private static int Reverse(int x) {
        int y = 0;
        while (x > 0) {
            y = y * 10 + x % 10;
            x /= 10;
        }
        return y;
    }
}
