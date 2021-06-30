// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

public class Solution {
    public int Reverse(int x) {
        string str = new string(x.ToString().Trim('-'.Reverse().ToArray()));
        bool tryInt32 = int.TryParse(str, out int intValue);
        return tryInt32 ? x.ToString().Contains("-") ? intValue * -1 : intValue : 0;
}