public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int iterator = 0;
            int n = words.Length;

            while (iterator != n)
            {
                if (words[(startIndex + iterator) % n] == target || words[(startIndex - iterator + n) % n] == target) // nice formula to iterate an array
                    return iterator;
                iterator++;
            }
            return -1;
    }
}
