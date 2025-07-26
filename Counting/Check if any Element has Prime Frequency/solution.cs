public class Solution {
    public bool CheckPrimeFrequency(int[] nums) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!frequency.ContainsKey(nums[i]))
            {
                frequency[nums[i]] = 0;
            }
            frequency[nums[i]]++;
        }
        foreach(KeyValuePair<int,int> number in frequency){
            bool isPrime = IsPrime(number.Value);
            if(isPrime)
                return true;
        }
        return false;
    }

    public bool IsPrime(int number){
        if(number == 1)
            return false;
        for(int i = 2; i <= (number * 0.5); i++){
            if(number % i == 0)
                return false;
        }
        return true;
    }
}
