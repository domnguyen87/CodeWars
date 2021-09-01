// Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
// Input: n = 5
// Output: [0,1,1,2,1,2]
// Explanation:
// 0 --> 0
// 1 --> 1
// 2 --> 10
// 3 --> 11
// 4 --> 100
// 5 --> 101



public class Solution {
    public int[] CountBits(int n) {
        int[] answer  = new int[num+1];
        answer[0] = 0;
        if( num == 0) return answer;
        for(int i = 1; i<= num; i++)
        {
            answer[i] = 1 + answer[i&(i=1)];
        }
        return answer;
    }
}