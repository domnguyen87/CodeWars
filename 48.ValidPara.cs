// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.

public class Solution {
    public bool IsValid(string s) {
        var arr = new List<char>();
        foreach (var c in s.ToCharArray())
        {
            switch(c)
            {
                case '(':
                arr.Add(')');
                break;
                case '{':
                arr.Add('}');
                break;
                case '[':
                arr.Add(']');
                break;

                default:
                if(arr.Count() > 0 && [arr.Count() - 1] == c)
                {
                    arr.RemoveAt(arr.count() - 1);
                }
                else{
                    return false;
                }
                break;
            
            }
        }
        
        return arr.Any();
    }
}