// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

// Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
// Output: 6
// Explanation: [4,-1,2,1] has the largest sum = 6.

public class Solution {
    public int MaxSubArray(int[] nums) {
        if(num.Length == 1)
        {
            return nums[0];
        }

        int sum = nums[0], max = nums[0];
        for ( int i = 1; i < nums.Length; i ++)
        {
            sum +=nums[i];

            if(nums[i] > sum)
            {
                sum = nums[i];
            }

            if(sum > max)
            {
                max = sum;
            }
        }

        return max;
    }
}