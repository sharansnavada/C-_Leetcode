public class Solution {
    public char FindTheDifference(string s, string t) {
        int sumS = 0, sumT = 0;

        foreach (char c in s)
            sumS += c;

        foreach (char c in t)
            sumT += c;

        return (char)(sumT - sumS);
    }
}
