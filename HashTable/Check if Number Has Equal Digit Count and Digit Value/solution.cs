public class Solution {
    public bool DigitCount(string num) {
        int[] hashTable = new int[10];

        foreach(char number in num){
            hashTable[int.Parse(number.ToString())]++;
        }

        for(int i = 0; i < num.Length; i++){
            if(hashTable[i] != int.Parse(num[i].ToString()))
                return false;
        }

        return true;
    }
}
