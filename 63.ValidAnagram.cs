// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

// Input: s = "anagram", t = "nagaram"
// Output: true

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        char[] ch1 = s.ToCharArray();
        char[] ch2 = l.ToCharArray();

        Array.Sort(ch1);
        Array.Sort(ch2);

        for ( int i = 0; i < ch1.Length; i++) 
        {
            if(ch1[i] != ch2[i])
            return false;
        }

        return true;
    }
}