//Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

// Example:
// XO("ooxx") => true
// XO("xooxx") => false
// XO("ooxXm") => true
// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
// XO("zzoo") => false

public static class Kata
{
    public static bool XO(string input)
    {
        return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o')
    }
}