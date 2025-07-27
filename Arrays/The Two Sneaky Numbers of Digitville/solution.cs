public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int arrIndex = 0;
        int[] returnArr = new int[2];
        Dictionary<int,int> frequencyCounter = new Dictionary<int,int>();

        foreach(int number in nums){
            if(!frequencyCounter.ContainsKey(number))
                frequencyCounter[number] = 0;
            frequencyCounter[number]++;
            if(frequencyCounter[number] == 2){
                returnArr[arrIndex] = number;
                arrIndex++;
            }
        }
        Array.Sort(returnArr);
        return returnArr;
    }
}
