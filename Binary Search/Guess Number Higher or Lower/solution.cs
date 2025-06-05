/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int high = n;
        int low = 1;
        int guesss = 0;
        int mid = 0;

         while(low <= high){
            mid = low + (high - low) / 2;
            guesss = guess(mid);

            if(guesss == 0){
                return mid;
            }
            else if(guesss == (-1)){
                high = mid - 1;
            }
            else if(guesss == 1){
                low = mid + 1;
            }
         }
         return 0;
        }
}
