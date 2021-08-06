// // Given a string s consists of some words separated by some number of spaces, return the length of the last word in the string.
// // A word is a maximal substring consisting of non-space characters only.

// Input: s = "Hello World"
// Output: 5

public class Solution {
    public int LengthOfLastWord(string s)
    {
        string[] words = s.Trim().Split(' ');
        return words[words.Length - 1].Length;    
        
    }
}