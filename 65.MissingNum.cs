// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

// Input: nums = [3,0,1]
// Output: 2

public class Solution {
    public int MissingNumber(int[] nums) {
        int sum = nums.Length * (nums.Length + 1) / 2;

        for( int i  = 0; i < nums.Length; i++) {
            sum -= nums[i];
        }

        return sum;
    }

    public int next ( int[] nums) {
        int sumNum = 0;
        int i = 0;
        for(int i ; i < nums.Length; i++)
        {
            sumNum +=i;
            sumNum -+ nums[i]
        }
        sumNum +=i;

        return sumNum;
    }
}