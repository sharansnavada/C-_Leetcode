public class Solution {
    public bool AreNumbersAscending(string s) {
        string[] splitStr = s.Split(" ");
        int previousNum = -1;

        foreach (string words in splitStr)
        {
            if (char.IsNumber(words[0]))
            {
                string number = "";
                foreach (char num in words)
                {
                    number += num.ToString();
                }
                if (int.Parse(number) <= previousNum)
                {
                    return false;
                }
                previousNum = int.Parse(number);
            }
        }
        return true;
    }
}
