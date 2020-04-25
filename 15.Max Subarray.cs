// Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum.

// Example:

// Input: [-2,1,-3,4,-1,2,1,-5,4],
// Output: 6
// Explanation: [4,-1,2,1] has the largest sum = 6.

public int MaxSubArray(int[] nums) {
    int sum = 0;
    int maxSum = nums[0];

    for (int i = 0; i < nums.Length; i++) {
        sum += nums[i];
        if(nums[i] > sum) {
            sum = nums[i];
        } 

        if(sum > maxSum) {
            maxSum = sum;
        }
    }

    return maxSum;
}