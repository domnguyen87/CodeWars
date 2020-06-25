// A valid parentheses string is either empty (""), "(" + A + ")", or A + B, where A and B are valid parentheses strings, and + represents string concatenation.  For example, "", "()", "(())()", and "(()(()))" are all valid parentheses strings.
// A valid parentheses string S is primitive if it is nonempty, and there does not exist a way to split it into S = A+B, with A and B nonempty valid parentheses strings.
// Given a valid parentheses string S, consider its primitive decomposition: S = P_1 + P_2 + ... +P_k, where P_i are primitive valid parentheses strings.
// // Return S after removing the outermost parentheses of every primitive string in the primitive decomposition of S.

// Input: "(()())(())"
// Output: "()()()"

public class Solution
{
    public string RemoveOuterParentheses(string S)
    {
        List<char> chars = new List<char>();
        int count = 1;
        int len = S.Length;
        for (int i = 1; i < len; i ++) {
            if (S[i] == '(') {
                count++;
            } else {
                count--;
            }

            if (count == 0) {
                i++;
                count = 1;
            } else {
                chars.Add(S[i]);
            }
        }

        return new string(chars.ToArraay());
    }
}