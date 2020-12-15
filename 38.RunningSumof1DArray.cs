// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]...sum[1])
// Return the running sum

// Example:
// nums = [1,2,3,4]
// output = [1,3,6,10]
// Explanation: [ 1, 1+2, 1+2+3, 1+2+3+4]

public class Solution {
    public int[] RunningSum(int[] nums)
    {
        for(int i = 1; i< nums.Length; i++)
        {
            nums[i] += nums[ i-1];
        }
        return nums;
    }
}

// js
// var runningSum = function(nums) {
//     for(let i = 1; i <nums.Length; i++) {
//         nums[i] += nums[ i-1 ];
//     }
//     return nums;
// }