// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Output: Because nums[0] + nums[1] == 9, we return [0, 1].

public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] result = new int[2];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j <nums.Length; j++)
            {
                if(nums[i] + nums [j] == target)
                {
                    results[0] = i;
                    results[1] = j;
                }
            }
        }
        
    }
}