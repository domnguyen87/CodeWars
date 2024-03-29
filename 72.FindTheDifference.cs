// You are given two strings s and t.
// String t is generated by random shuffling string s and then add one more letter at a random position.
// Return the letter that was added to t.


public class Solution {
    public char FindTheDifference(string s, string t) {
        int result = 0;
        foreach (var c in s)
            result ^= c;
        foreach (var c in t)
            result ^= c;
        return (char)result;
    }
}
