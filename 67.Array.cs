// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

// Note that you must do this in-place without making a copy of the array.
// Input: nums = [0,1,0,3,12]
// Output: [1,3,12,0,0]

public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int curr = 0;
        int next = 1;

        while ( next< nums.Length)
        {
            if(nums[curr] == 0)
            {
                if(nums[next] == 0)
                {
                    next++;
                    continue;
                }
                else
                {
                    nums[curr]  = nums[next];
                    nums[next] = 0;
                }
            }

            curr++;
            next++;
        }
    }
}