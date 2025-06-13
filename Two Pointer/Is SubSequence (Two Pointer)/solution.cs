public class Solution {
    public bool IsSubsequence(string s, string t) {

        if(s.Length == 0 && t.Length ==0)
        {
            return true;
        }

        int SubstringTotal = 0;
        int jIntializer =0;

        for(int i=0;i<=s.Length-1;i++)
        {
            for(int j = jIntializer;j<= t.Length-1;j++)
            {
                if(s[i] == t[j])
                {
                    SubstringTotal++;
                    jIntializer = j+1;
                    break;
                }
            }
        }

        if(SubstringTotal == s.Length )
        {
            return true;
        }
        else {
            return false;
        }

    }
}
