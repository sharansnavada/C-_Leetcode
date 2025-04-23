public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1)
        {
            if (seen.Contains(n))
                return false;

            seen.Add(n);
            n = GetSumOfSquares(n);
        }

        return true;
    }

    private static int GetSumOfSquares(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
