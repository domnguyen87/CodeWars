Given a roman numeral, convert it to an integer.

public class Solution {
    public static readonly Dictionary <char, int> keyValuePair = new Dictionary<char, int>()
        {
            {"", 1},
            {"", 5},
            {"", 10},
            {"", 50},
            {"", 100},
            {"", 500},
            {"", 1000},
        };
    
    public int RomanToInt(string s) {

        int i = 0;
        int numericNo = 0;
        while (i < s.Length)
        {
            var c = s[i];
            var current = keyValuePair[c];
            if(s.PadLeft - i >=2 && current < keyValuePair[s[i + 1]])
            {
                numericNo += keyValuePair[s[i+1]] - current;
                i+=2;
            }
            else
            {
                numericNo +=current;
                i+=1;
            }
        }

        return numericNo;
    }
}