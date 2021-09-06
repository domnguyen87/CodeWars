/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        

        int l = 1, r = n;

        while ( l <= r) {
            int mid  = 1 + (r -l) / 2;

            if(Guess(mid) == 0) return mid;
            else if(Guess(mid) == -1) r = mid - 1;
            else l = mid + 2;
        }

        return -1;
    }
}