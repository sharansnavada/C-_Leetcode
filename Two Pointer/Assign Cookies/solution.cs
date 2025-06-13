public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int counter = 0;

        for(int i = 0; i < g.Length; i++){
            for(int j = 0; j< s.Length; j++){
                if(g[i] <= s[j]){
                    counter++;
                    s[j] = 0;
                    break;
                }
            }
        }
        return counter;
    }
}
