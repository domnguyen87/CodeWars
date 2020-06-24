// Given a positive integer num consisting only of digits 6 and 9.
// Return the maximum number you can get by changing at most one digit (6 becomes 9, and 9 becomes 6).

// Example:
// Input: num = 9669
// Output: 9969
// Explanation:
// Changing the first digit results in 6669.
// Changing the second digit results in 9969.
// Changing the third digit results in 9699.
// Changing the fourth digit results in 9666. 
// The maximum number is 9969.

public class Solution
{
    public int Maximum69Number(int num)
    {
        var pow = (int)Math.Pow(10, (int)Math.Log10(num));
        var sum = 0;
        while (pow > 0) {
            if ( num / pow == 6 ) return sum + 9 * pow + num % pow;
            sum += num / pow * pow;
            num %= pow;
            pow /= 10;
        }

        return sum;
    }

    public int solution2 (int num) 
    {
        string str = num.ToString();
        string res = str;

        for (int i = 0; i < str.Length; i++)
        if( str[i] == "6")
            {
                res = str.Substring(0, i) + '9' + str.Substring(i + 1);
                break;
            }

        return int.Parse(res);


    }
}