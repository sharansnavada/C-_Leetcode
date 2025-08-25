public class Solution {
    public int CountBeautifulPairs(int[] nums) {
        int counter = 0;

        for(int i = 0; i < nums.Length - 1; i++){
            for(int j = i + 1; j < nums.Length; j++){
                counter += IsGcd(nums[i],nums[j]) ? 1 : 0;
            }
        }
        return counter;
    }

    public bool IsGcd(int num1, int num2)
    {
        List<int> divList = new List<int>();
        if (num1 >= 10)
            num1 = int.Parse(num1.ToString()[0].ToString());
        if (num2 >= 10)
            num2 = num2 % 10;//int.Parse(num2.ToString()[1].ToString());

        for (int i = 2; i <= num1; i++)
        {
            if (num1 % i == 0)
                divList.Add(i);
        }
        for (int j = 2; j <= num2; j++)
        {
            if (num2 % j == 0 && divList.Contains(j))
                return false;
        }
        return true;
    }
}
