public class Solution {
    public int MinDeletionSize(string[] strs) {
        int numberOfColumnsDeleted = 0;
    int iterations = 0;

    while (iterations < strs[0].Length) {
        for (int i = 1; i < strs.Length; i++) {
            char prevChar = strs[i - 1][iterations];
            char currentChar = strs[i][iterations];

            if (prevChar > currentChar) {
                numberOfColumnsDeleted++;
                break;
            }
        }
        iterations++;
    }

    return numberOfColumnsDeleted;
    }
}
