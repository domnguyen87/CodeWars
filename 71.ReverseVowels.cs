// Given a string s, reverse only all the vowels in the string and return it.
// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both cases.
// Input: s = "hello"
// Output: "holle"

public class Solution {
    public string ReverseVowels(string s) {
        int i = 0;
        int j = s.Length-1;
        StringBuilder sb = new StringBuilder(s);
        while(i < j) {
            if(isVowel(s[i]&&isVowel(s[j]))){
                sb[i] = s[j];
                sb[j] = s[i];
                i++;
                j--
            }
            else if(isVowel(s[i]))
                j--;
            else if(isVowel(s[j]))
                i++;
                j--;
        }
    }

    public bool isVowel(char ch) {
        return (ch =='a' || ch =='e' || ch =='o' || ch =='u' || ch =='A' || ch =='E' || ch =='I' || ch =='o' || ch =='u' ||)
    }
}