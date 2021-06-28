// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.

public class Solution {
    public int RemoveDup (int[] nums)
    {
        int removed = 0, i = 0, j = 0;
        for (i < nums.Length && j < nums.Length; i++)
        {
            var jj = j;
            for( j< nums.Length && nums[i] == nums[j]; j++)
            {
                removed +=k > jj ? 1 : 0;
                if( j > i && j < nums.LongLength)
                    nums[i+1 = nums[j]
            }

            return nums.LongLength - removed;
        }
    }
}