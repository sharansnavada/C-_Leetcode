public class Solution {
    public int DigitFrequencyScore(int n) {
        int[] hashTable = new int[10];
        int num = n;
        int digit = 0;
 
        while(num > 0){
            digit = num % 10;
            num /= 10;
            hashTable[digit]++;
        }
 
        int sum = 0;
        num = n;
 
        while(num > 0){
            digit = num % 10;
            num /= 10;
            sum += hashTable[digit] * digit;
            hashTable[digit] = 0;
        }
        return sum;
    }
}