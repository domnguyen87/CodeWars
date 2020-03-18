//Implement a function  that adds two numbers together  and return their sum in binary
//The conversion can be done before or after the addition
//The Binary number should returned should be a string

using System;

public static class Kata
{
    public static string AddBinary(int a, int b) =>
        Convert.ToString(a + b, 2);

    public static string AddBinary2(int a, int b)
    {
        return Convert.ToString(a + b, 2);
    }
}