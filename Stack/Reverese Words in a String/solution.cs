public class Solution {
    public string ReverseWords(string s)
    {
        Stack<string> stk = new Stack<string>();
        List<string> strArr = SplitWords(s);
        

        StringBuilder sb = new StringBuilder();

        foreach (string word in strArr)
        {
            stk.Push(word);
        }

        while (stk.Count != 0)
        {
            sb.Append(stk.Pop());
        }

        return sb.ToString().Trim();
    }

    public List<string> SplitWords(string s)
    {
        List<string> strArr = new List<string>();
        string strConcat = "";

        foreach (char letter in s)
        {
            if (letter != ' ')
            {
                strConcat += letter;
            }
            else if (letter == ' ')
            {
                if (strConcat != "")
                {
                    strArr.Add(strConcat);
                    strConcat = "";
                    strArr.Add(" ");
                }
                // else
                // {
                //     strArr.Add(" ");
                // }
            }
        }
        if (strConcat != "")
        {
            strArr.Add(strConcat);
        }
        return strArr;
    }
}
