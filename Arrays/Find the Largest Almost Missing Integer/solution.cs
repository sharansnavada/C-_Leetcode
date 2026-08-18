public class Solution {
    public int LargestInteger(int[] nums, int k) {
         Dictionary<int, int> dict = new Dictionary<int, int>();

    for (int i = 0; i <= nums.Length - k; i++)
    {
        HashSet<int> seenInWindow = new HashSet<int>();

        for (int j = 0; j < k; j++)
        {
            int number = nums[i + j];

            if (seenInWindow.Add(number)) 
            {
                if (!dict.ContainsKey(number))
                    dict[number] = 0;

                dict[number]++;
            }
        }
    }

    return dict
        .Where(x => x.Value == 1)
        .Select(x => x.Key)
        .DefaultIfEmpty(-1)
        .Max();
    }
}
