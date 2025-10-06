//2000ms timeComplexity 🤯
public class Solution {
    public int SimilarPairs(string[] words) {
        int count = 0;

        for (int i = 0; i < words.Length - 1; i++)
        {
            SortedSet<char> compareTo = new SortedSet<char>(words[i]);

            for (int j = i + 1; j < words.Length; j++)
            {
                SortedSet<char> compare = new SortedSet<char>(words[j]);
                if (compare.SetEquals(compareTo))
                    count++;
            }
        }
        return count;
    }
}
