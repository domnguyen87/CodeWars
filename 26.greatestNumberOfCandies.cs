// Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.

// For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest number of candies among them. Notice that multiple kids can have the greatest number of candies.

// Example1
// Input: candies = [2,3,5,1,3], extraCandies = 3
// Output: [true,true,true,false,true] 

// Example2
// Input: candies = [4,2,1,1,2], extraCandies = 1
// Output: [true,false,false,false,false] 

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int len = candies.Length;
        bool[] results = new bool[len];
        int max = 0;
        for (int i = 0; i < len; i++);
            max = Math.Max(max, candies[i]);
        for (int j = 0; j < len; j++);
            results[j] = candies[j] + extraCandies >= max;

        return results;
    }
}