public class Solution {
    public int MinSwaps(string s) {
        int closingBrackets = 0;
        int openingBrackets = 0;
        int retCount = 0;
        char[] charArr = s.ToCharArray();
        int lastIndex = charArr.Length - 1;

        for(int i = 0; i < charArr.Length; i++)
        {
            if(charArr[i] == ']') closingBrackets++;
            else openingBrackets++;

            if(closingBrackets > openingBrackets)
            {
                while(charArr[lastIndex] != '[' && lastIndex > i)
                {
                    lastIndex--;
                }
                charArr[i] = '[';
                charArr[lastIndex] = ']';
                openingBrackets++;
                closingBrackets--;
                retCount++;
            }
            
        }

        return retCount;
    }
}
