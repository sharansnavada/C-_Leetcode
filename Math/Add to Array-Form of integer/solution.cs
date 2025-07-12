public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        int carry = 0;
        string kString = k.ToString();
        int numLength = num.Length - 1; int kLength = kString.Length - 1;
        List<int> res = new List<int>();

        while (kLength != -1 && numLength >= 0)
        {
            int sum = num[numLength] + int.Parse(kString[kLength].ToString()) + carry;
            if (numLength == 0 && kLength == 0)
            {
                if (sum > 9)
                {
                    res.Insert(0, int.Parse(sum.ToString()[1].ToString()));
                    res.Insert(0, int.Parse(sum.ToString()[0].ToString()));
                }
                else
                    res.Insert(0, sum);
            }
            else
            {
                carry = sum / 10;
                res.Insert(0, sum % 10);
            }
            numLength--; kLength--;
        }

        if (kLength == -1)
        {
            for (int i = numLength; i >= 0; i--)
            {
                int sum = num[i] + carry;
                if (i == 0)
                {
                    if (sum > 9)
                    {
                        res.Insert(0, int.Parse(sum.ToString()[1].ToString()));
                        res.Insert(0, int.Parse(sum.ToString()[0].ToString()));
                    }
                    else
                        res.Insert(0, sum);
                }
                else
                {
                    carry = sum / 10;
                    res.Insert(0, sum % 10);
                }
            }
        }
        else if (numLength == -1)
        {
            for (int i = kLength; i >= 0; i--)
        {
            int sum = int.Parse(kString[i].ToString()) + carry;
            if (i == 0)
            {
                if (sum > 9)
                {
                    res.Insert(0, int.Parse(sum.ToString()[1].ToString()));
                    res.Insert(0, int.Parse(sum.ToString()[0].ToString()));
                }
                else
                    res.Insert(0, sum);
            }
            else
            {
                carry = sum / 10;
                res.Insert(0, sum % 10);
            }
        }
        }

        return res.ToArray();
    }
}
