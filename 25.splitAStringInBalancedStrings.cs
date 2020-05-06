// Balanced strings are those who have equal quantity of 'L' and 'R' characters.
// Given a balanced string s split it in the maximum amount of balanced strings.
// Return the maximum amount of splitted balanced strings.

// Example 1:
// Input: s = "RLRRLLRLRL"
// Output: 4
// Explanation: s can be split into "RL", "RRLL", "RL", "RL", each substring contains same number of 'L' and 'R'.

public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int count = 0, res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'R')
                count++;
            else if (s[i] == "L")
                count--;
            if (count == 0)
                res++;
        }

        return res;
    }
}