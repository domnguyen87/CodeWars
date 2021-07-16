// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
// You must write an algorithm with O(log n) runtime complexity.
// Input: nums = [1,3,5,6], target = 5
// Output: 2

public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        int i = 0;
        int j = nums.Length -1;
        while (i <= j){
            int mid = i + ( j - 1) / 2;
            if(target < nums[mid])
                j = mid - 1;
            else if ( target > nums[mid])
                i = mid + 1;
            else return mid;
        }

        return i;
    }
}