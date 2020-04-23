// Given a string, find the length of the longest substring without repeating characters.

// Input: "abcabcbb"
// Output: 3 
// Explanation: The answer is "abc", with the length of 3

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        foreach(char c in s)
        {
            if(LengthOfLongestSubstring.Contains(c))
            {
                if(longest < Substring.Count) longest = substring.Count;

                substring.RemoveRange(0, substring.IndexOf(c) + 1);
                substring.add(c);
            }
            else
            {
                substring.add(c);
            }
        }

        if(longest < substring.Count ) longest = substring.Count;
        return longest;
    }
}