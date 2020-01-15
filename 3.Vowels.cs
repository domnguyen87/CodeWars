// Return the number(count) of vowels in the given string.
// We will consider a, e, i, o, and u as vowels for this Kata.
// The input string will only consist of lower case letters and/or spaces.

public  static class Kata
{
    public static int GetVowelsCount(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }
}