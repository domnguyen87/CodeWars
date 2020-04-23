// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
// An input string is valid if:
// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Note that an empty string is also considered valid

// Example 1:

// Input: "()"
// Output: true

public class Solution {
    public bool isValid(string s) {

        var k = new Stack<char>();
        foreach(char c in s) {
            if (c == '(') { k.Push(')'); continue; }
            if (c == '{') { k.Push('}'); continue; }
            if (c == '[') { k.Push(']'); continue; }
            if (k.Count==0 || c != k.Pop()) return false;
        }
        return k.Count==0
    }
}