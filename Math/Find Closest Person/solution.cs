public class Solution {
    public int FindClosest(int x, int y, int z) {
        x = Math.Abs(x - z);
        y = Math.Abs(y - z);

        if(x == y) return 0;
         return x < y ? 1 : 2;
    }
}
