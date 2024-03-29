// Given an array of integers where 1 ≤ a[i] ≤ n(n = size of array), some elements appear twice and others appear once.
// Find all the elements of [1, n] inclusive that do not appear in this array.
// Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.

// Example:
// Input:
// [4,3,2,7,8,2,3,1]
// Output:
// [5,6]

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int val = Math.Abs(nums[i]);
            nums[val - 1] = -Math.abs(nums[val - 1]);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                res.Add(i + 1);
            }
        }

        return res;
    }
}