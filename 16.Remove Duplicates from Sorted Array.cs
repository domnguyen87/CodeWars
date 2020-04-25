// Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
// Example:
// Given nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4],
// Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.

public int removeDuplicates(int[] nums) {
    if(nums.Length == 0) return 0;
    int i = 0;
    for (int j = 1; j < nums.Length; j++) {
        if(nums[j] != nums[i]) {
            i++;
            nums[i] = nums [j]
        }
    }
    return i + 1;
}