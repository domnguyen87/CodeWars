// Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

// Input: num = 38
// Output: 2
// Explanation: The process is
// 38 --> 3 + 8 --> 11
// 11 --> 1 + 1 --> 2 
// Since 2 has only one digit, return it.

public class Solution {
    public int AddDigits(int num) {
        while (num > 10)
        {
            num = Helper(num)
        }
    }

    public int Helper(int num, int sum = 0)
    {
        if (num < 10)
        {
            sum += num;
            return sum;
        }

        return Helper(num % 10, sum + num/10)
    }
}