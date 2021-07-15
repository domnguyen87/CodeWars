// You are climbing a staircase. It takes n steps to reach the top.

// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

// Input: n = 2
// Output: 2
// Explanation: There are two ways to climb to the top.
// 1. 1 step + 1 step
// 2. 2 steps

public class Solution {
    public int ClimbStairs(int n) {
        if(n < 0 ) return 0;
        if( n <= 2) return n;

        int f1 = 1;
        int f2 = 2;
        int result = 0;

        for ( int i = 2; i < n; i++)
        {
            result = f1 + f2;
            f1 = f2;
            f2 = results; 
        }

        return f2;
    }
}