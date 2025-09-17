//worst time complexity (232ms) 😱
public class Solution
{
    public int CountPrimeSetBits(int left, int right)
    {
        int primeBits = 0;

        for (int i = left; i <= right; i++)
        {
            primeBits += IsPrime(CountPrimeSetBitsForIndivisualNumber(i)) ? 1 : 0;
        }
        return primeBits;
    }

    public int CountPrimeSetBitsForIndivisualNumber(int number)
    {
        int quotient = number, remainder = 0;
        string binary = "";
        int bitsCount = 0;

        while (quotient > 0)
        {
            remainder = quotient % 2;
            binary = remainder.ToString() + binary; 
            bitsCount += remainder == 1 ? 1 : 0;
            quotient = quotient / 2;
        }

        return bitsCount;
    }

    public bool IsPrime(int number)
    {
        if (number == 1 || number == 0)
            return false;

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
