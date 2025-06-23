public class Solution {
    public string ReverseOnlyLetters(string s) {
        string[] charArr = new string[s.Length];
        StringBuilder sb = new StringBuilder();
        
        // Step 1: Collect all letters in reverse order
        for (int i = s.Length - 1; i >= 0; i--) {
            if (char.IsLetter(s[i])) {
                sb.Append(s[i]);
            }
        }

        int sbCounter = 0;
        // Step 2: Reconstruct the result
        for (int i = 0; i < s.Length; i++) {
            if (char.IsLetter(s[i])) {
                charArr[i] = sb[sbCounter].ToString();
                sbCounter++;
            } else {
                charArr[i] = s[i].ToString();
            }
        }

        // Step 3: Build final string
        StringBuilder st = new StringBuilder();
        foreach (string ss in charArr) {
            st.Append(ss);
        }

        return st.ToString();
    }
}
