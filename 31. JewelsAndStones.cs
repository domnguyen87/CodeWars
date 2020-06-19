// You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
// The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A"

// Example
// Input: J = "aA", S = "aAAbbbb"
// Output: 3

public class Solution
{
    //LINQ
    public int NumJewelsInStones(string J, string S)
    {
        return S.Count(stone => J.Contains(stone));
    }

    //Hash
    public int NumJewelsInStones(string J, string S)
    {
        if(string.IsNullOrEmpty(S) || string.IsNullOrEmpty(J)){
            return 0;
        }

        HashSet<char> jewels = new HashSet<char>();
        int jewelCount = 0;

        for (int i = 0; i < J.Length; i++) {
            jewels.Add(J[i]);
        }

        for (int i = 0; i < S.Length; i++) {
            if(jewels.Contains(S[i])) {
                jewelCount++;
            }
        }

        return jewelCount;
    }
}