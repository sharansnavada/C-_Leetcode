public class Solution
{
    public int MinTimeToType(string word)
    {
        int time = 0;
        char current = 'a'; // starting position

        for (int i = 0; i < word.Length; i++)
        {
            // Calculate clockwise distance
            int clockwise = Math.Abs(word[i] - current);

            // Choose the minimum distance between clockwise & counterclockwise
            int minDistance = Math.Min(clockwise, 26 - clockwise);

            // Add movement time + 1 second to type the character
            time += minDistance + 1;

            // Update current position
            current = word[i];
        }

        return time;
    }
}
