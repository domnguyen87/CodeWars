// Given an array, rotate the array to the right by k steps, where k is non-negative.

// Input: [1,2,3,4,5,6,7]
// and k = 3
// Output: [5,6,7,1,2,3,4]
// Explanation:
// rotate 1 steps to the right: [7,1,2,3,4,5,6]
// rotate 2 steps to the right: [6,7,1,2,3,4,5]
// rotate 3 steps to the right: [5,6,7,1,2,3,4] 

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        var temp = nums[0];
        for (var i = 0; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[nums.Length - 1] = temp;
    }
}