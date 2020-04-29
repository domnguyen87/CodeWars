// Given an array of size n, find the majority element.The majority element is the element that appears more than ⌊ n/2 ⌋ times.
// You may assume that the array is non-empty and the majority element always exist in the array.
// Example 1:
// Input: [3,2,3]
// Output: 3

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        nums.OrderBy(x => x).ToArray()[nums.Length / 2];
    }

    public int ME(int[] nums)
    {
        int count = 1;
        nums = nums[0];

        foreach (var n in nums) {
            count += num == n ? 1 : -1;

            if (count == 0) { nums = n; }
            count = Math.Max(count, 1);
        }
        return nums;
    }
}