//Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

public class Solution {
    public int ThirdMax(int[] nums) {
        var m = new HashSet <int>();
        
        foreach ( var n in nums ) {
        m.Add(n);
        if(m.Count > 3){
        m.Remove(m.Min());
        }
    }
    
    return m.Count == 3 ? m.Min() : m.Max();
    }
    
    //Solution2
     public static int ThirdMax(int[] nums)
        {
            nums = nums.OrderByDescending(n=>n).Distinct().ToArray();
            if (nums.Length < 3)
                return nums[0];

            return nums[2];
        }
}


