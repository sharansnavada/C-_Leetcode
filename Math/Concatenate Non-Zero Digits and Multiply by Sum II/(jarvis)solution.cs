// This is optimized code but the code is not mine
// In the previous commit of this file you can check 
// the worst optimized code written by me.
// I am too tired to think much harder as I had a long day 
// today in the work, I am so sorry for this.
using System;
using System.Collections.Generic;

public class Solution
{
    const long MOD = 1000000007;

    public int[] SumAndMultiply(string s, int[][] queries)
    {
        int n = s.Length;

        // Prefix sum of digit values.
        int[] digitPrefix = new int[n + 1];

        // Positions and values of non-zero digits.
        List<int> pos = new List<int>();
        List<int> digit = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int d = s[i] - '0';
            digitPrefix[i + 1] = digitPrefix[i] + d;

            if (d != 0)
            {
                pos.Add(i);
                digit.Add(d);
            }
        }

        int m = digit.Count;

        // Powers of 10 modulo MOD.
        long[] pow10 = new long[m + 1];
        pow10[0] = 1;
        for (int i = 1; i <= m; i++)
            pow10[i] = (pow10[i - 1] * 10) % MOD;

        // Prefix concatenation values.
        // concatPrefix[i] = number formed by first i non-zero digits.
        long[] concatPrefix = new long[m + 1];
        for (int i = 0; i < m; i++)
        {
            concatPrefix[i + 1] = (concatPrefix[i] * 10 + digit[i]) % MOD;
        }

        int[] ans = new int[queries.Length];

        for (int qi = 0; qi < queries.Length; qi++)
        {
            int l = queries[qi][0];
            int r = queries[qi][1];

            int sum = digitPrefix[r + 1] - digitPrefix[l];

            if (sum == 0)
            {
                ans[qi] = 0;
                continue;
            }

            int left = LowerBound(pos, l);
            int right = UpperBound(pos, r) - 1;

            int len = right - left + 1;

            long number =
                (concatPrefix[right + 1]
                - (concatPrefix[left] * pow10[len]) % MOD
                + MOD) % MOD;

            ans[qi] = (int)((number * sum) % MOD);
        }

        return ans;
    }

    private int LowerBound(List<int> arr, int target)
    {
        int l = 0, r = arr.Count;
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (arr[mid] < target)
                l = mid + 1;
            else
                r = mid;
        }
        return l;
    }

    private int UpperBound(List<int> arr, int target)
    {
        int l = 0, r = arr.Count;
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (arr[mid] <= target)
                l = mid + 1;
            else
                r = mid;
        }
        return l;
    }
}
