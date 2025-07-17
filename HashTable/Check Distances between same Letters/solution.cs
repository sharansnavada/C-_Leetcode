public class Solution {
    public bool CheckDistances(string s, int[] distance) {
        int[] firstIndex = new int[26];
        Array.Fill(firstIndex, -1); // Initialize with -1 to indicate not seen yet

        for (int i = 0; i < s.Length; i++) {
            int idx = s[i] - 'a';
            if (firstIndex[idx] == -1) {
                firstIndex[idx] = i; // Store first occurrence
            } else {
                int actualDistance = i - firstIndex[idx] - 1;
                if (actualDistance != distance[idx]) {
                    return false; // Not well-spaced
                }
            }
        }
        return true; // All characters matched the distance
    }
}
