// Count the number of prime numbers less than a non-negative number, n.
// Input: n = 10
// Output: 4
// Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.

public class Solution {
    public int CountPrimes(int n)
    {
        int p = 0;
        for ( int i = 0; i < n; i++)
        {
            if(isPrime(i))
            {
                p++;
            }
        }

        return p;
    }

    public bool isPrime(int number)
    {
        if (number <=1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundry = (int)Math.Floor(Math.Sqrt(number));

        for ( int i = 3; i <=boundry; i +=2)
        {
            if(number % i == 0) return false;
        }

        return true;
    }
}