//Given an integer x, return true if x is a palindrome, and false otherwise

// This implementation first checks if the input number x is negative, in which case it cannot be a palindrome and false is returned. Otherwise, the code proceeds to reverse the number by extracting its digits one by one and building a new number with them in reverse order. Finally, the code checks if the reversed number is equal to the original input number, and returns true if they are the same, or false otherwise.


public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0){
            return false;
        }
        int reversed = 0;
        int original = x;
        while(x != 0) {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return original == reversed;
    }
}