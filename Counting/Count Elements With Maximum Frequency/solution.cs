public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        int maxFrequency = 0;
        int returnSum = 0;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int number in nums){
            if(!dict.ContainsKey(number))
                dict[number] = 0;
            dict[number] += 1;
            if(dict[number] > maxFrequency)
                maxFrequency = dict[number];
        }

        foreach(var kvp in dict){
            if(kvp.Value == maxFrequency){
                returnSum += maxFrequency;
            }
        }

        return returnSum;
    }
}
