// Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
// Example:
// Input: [0,1,0,3,12]
// Output: [1,3,12,0,0]

public void MoveZeros(int[] nums){
    int j = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] ! = 0)
        {
            nums[j++] = nums[i];
        }

        while(j < nums.Length)
        {
            nums[j++] = 0;
        }
    }
}