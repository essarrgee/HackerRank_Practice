public class Solution {
    public string BreakPalindrome(string palindrome) {
        int length = (int)(Math.Floor((double)(palindrome.Length/2)));
        bool mutable = false;
        for (int i=0; i<length; i++) {
            if (palindrome[i] == palindrome[palindrome.Length-1-i] && (i != palindrome.Length-1-i)) {
                if (palindrome[i] > 'a') {
					// Replace with 'a'
                    palindrome = palindrome.Remove(i, 1);
                    palindrome = palindrome.Insert(i, "a");
                    mutable = true;
                    break;
                }
                
            }
        }
		// If palindrome wasn't mutable and characters at
		// index 0 and the last index are equal ('a' == 'a'),
		// set the character at the last index to 'b'
        if (!mutable) {
            if (palindrome[0] == palindrome[palindrome.Length-1] && (palindrome.Length-1 != 0)) {
                palindrome = palindrome.Remove(palindrome.Length-1, 1);
                palindrome = palindrome.Insert(palindrome.Length, "b"); // Insert last
                mutable = true;
            }
        }
        if (mutable) {
            return palindrome;
        }
        else {
            return ""; // Return empty string if still immutated
        }
    }
}