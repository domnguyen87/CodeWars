//Complete the function that accepts a string parameter, and reverse each word in the string. All spaces in the string should be retained
//Example
//"This is an example!" ==> "siht si na !elpmaxe"
//"double space" ==> "elbuod ecaps"

public static class Kata
{
    public static string ReverseWords(string str)
    {
        return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
    }
}