// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
// Follow up: Could you implement a solution with a linear runtime complexity and without using extra memory?
// Input: nums = [4,1,2,1,2]
// Output: 4


public class Solution {
    public int SingleNumber(int[] nums) {
        int result = nums[0];

        for(int i =1; i<nums.Length; i++){
            results^= nums[i];
        }

        return results;
    }
}