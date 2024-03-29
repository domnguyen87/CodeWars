// An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

// Given an integer n, return true if n is an ugly number.

// Input: n = 6
// Output: true
// Explanation: 6 = 2 × 3

// Input: n = 14
// Output: false
// Explanation: 14 is not ugly since it includes the prime factor 7.

public class Solution {
    public bool IsUgly(int n) {

        if( n == 0)
        {
            return false;
        }
        while ( n != 0)
        {
            if( n % 2 == 0)
            {
                n = n / 2;
            }
            else if ( n % 3 == 0)
            {
                n = n / 3;
            }
            else if ( n % 5 == 0)
            {
                 n = n / 5;
            }
            else return false;
        }
    }
}