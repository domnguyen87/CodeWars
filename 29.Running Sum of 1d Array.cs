// Given an array nums.We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
// Return the running sum of nums.

// Example
// Input: nums = [1,2,3,4]
// Output: [1,3,6,10]
// Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].


public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int sum = 0;
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            result[i] = sum;
        }

        return result;
    }
}