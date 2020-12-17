// Write a function that reverses a string. The input string is given as an array of characters char[].
// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

public class Solution {
    public void ReverseString(char[] s) {
        int lo, hi = s.Length-1; // Initialize Two Pointers to start and end of array
        while(lo<=hi) {
            var temp = s[lo]; //store into temp variable
            s[lo] = s[hi]; // switch #1
            s[hi] = temp; // switch #2
            lo+=1;
            hi-=1;
        }
    }
}

//JS
//const reverseString = (s) => {
//let i1 = 0;    
//let i2 = s.length -1;
//while( i1 < i2){
//const temp = s[i1];
//s[i1] = s[i2];
//s[i2] = temp;
//i1++
//i1--
//}
//}