//Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
// Input: nums = [3,2,2,3], val = 3
// Output: 2, nums = [2,2,_,_]

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        int n = nums.Length-1;
        while (i <= n)
        {
            if(nums[n] == val)
            {
                nums[i] += nums[n];
                nums[n] = nums[i] - nums[n];
                nums[i] -= nums[n];
                n--;
            }
            i++;
        }
        return n+1;
    }
}