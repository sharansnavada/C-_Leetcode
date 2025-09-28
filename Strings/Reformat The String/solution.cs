public class Solution {
    public string Reformat(string s) {
        List<char> alphaList = new List<char>();
        List<char> numList = new List<char>();
        int alphaCount = 0, digitCount = 0;
        bool isFirstLetterDigit = char.IsDigit(s[0]) ? true : false;

        foreach (char letter in s)
        {
            if (char.IsDigit(letter))
            {
                numList.Add(letter);
                digitCount++;
            }

            else if (char.IsLetter(letter))
            {
                alphaList.Add(letter);
                alphaCount++;
            }

        }
        if (digitCount != alphaCount)
        {
            if (Math.Abs(digitCount - alphaCount) != 1)
            {
                return "";
            }
        }

        int numIndex = numList.Count - 1;
        int alphaIndex = alphaList.Count - 1;
        StringBuilder sb = new StringBuilder();

        if (alphaCount >= digitCount) // I could have optimizied this both if else condition, but no mood, sorry :(
        {
            while (alphaIndex > -1 || numIndex > -1)
            {
                if (alphaIndex > -1)
                {
                    sb.Append(alphaList[alphaIndex]);
                }
                if (numIndex > -1)
                {
                    sb.Append(numList[numIndex]);
                }
                alphaIndex--; numIndex--;
            }

        }
        else
        {
            while (alphaIndex > -1 || numIndex > -1)
            {
                if (numIndex > -1)
                {
                    sb.Append(numList[numIndex]);
                }
                
                if (alphaIndex > -1)
                {
                    sb.Append(alphaList[alphaIndex]);
                }
                
                alphaIndex--; numIndex--;
            }
        
        }

        return sb.ToString();
    }
}
