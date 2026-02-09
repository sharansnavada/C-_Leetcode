public class Solution {
    public int TrailingZeroes(int n) {
        int count = 0;
        while (n > 0) {
            n /= 5;
            count += n;
        }
        return count;
    }
}


// A trailing zero is created by 10 = 2 × 5.

// In a factorial:
// 	•	There are tons of 2s
// 	•	5s are rare

//  So the number of trailing zeros = number of times 5 appears

// That’s it.
