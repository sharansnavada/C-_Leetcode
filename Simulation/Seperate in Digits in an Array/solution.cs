public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> retList = new List<int>();
        foreach(int number in nums){
            if(number >= 10){
                string currentNum = number.ToString();
                foreach(char numb in currentNum){
                    retList.Add(int.Parse(numb.ToString()));
                }
            }
            else{
                retList.Add(number);
            }

        }
        return retList.ToArray();
    }
}
