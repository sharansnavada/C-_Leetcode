public class Solution {
    public string LargestGoodInteger(string num) {
        int largestNum = -1;

        for(int i = 0; i < num.Length - 2; i++){
            if(num[i] == num[i + 1] && num[i] == nums[i + 2]){
                int number = int.Parse(nums[i]);
                if(number > largestNum)
                    largestNum = number;
            }
        }
        
        string retStr = largestNum.ToString();
        if(largestNum == -1)
            return "";
        else
            return retStr+retStr+retStr;
    }
}
