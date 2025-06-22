public class Solution {
    public bool RotateString(string s, string goal) {
        int counter = 1;
        while (counter <= s.Length)
        {
            string goalEnd = s.Substring(counter, s.Length - counter);
            string goalStart = s.Substring(0, counter);
            StringBuilder sb = new StringBuilder();
            sb.Append(goalEnd); sb.Append(goalStart);

            if (sb.ToString() == goal)
            {
                return true;
            }
            counter++;
        }
        return false;
    }
}
