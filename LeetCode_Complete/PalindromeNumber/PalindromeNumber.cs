public class Solution {
    public bool IsPalindrome(int x) {
        int tempX = x;
        if (x < 0) { // If x is negative, is NOT a palindrome
            return false;
        }
        int count = (int) Math.Floor(Math.Log10(tempX)+1); // Get the total length of x
        int halfCount = (int) Math.Floor((double)(count/2)); // Get half the length of x
        bool result = true;
        List<int> xStore = new List<int>(); // Stores all "seen" numbers from one half of x
        for (int i=0; i<halfCount; i++) {
            int nextX = (int) (tempX%10); // Get next digit in x
            xStore.Add(nextX); // Add it to the "seen" list
            tempX = (int) Math.Floor((double)(tempX/10)); // Remove said digit from x
        }
        if (count%2 != 0) { // If total length of x is odd,
            int nextX = (int)(tempX%10); // add the middle digit to the "seen" list
            xStore.Add(nextX); // but don't remove it from x
        }
        for (int i=(halfCount+(count%2)-1); i>=0; i--) { 
			// Check the remaining half of x with the "seen" list
            int nextX = (int) (tempX%10);
            if (nextX != xStore[i]) { 
				// If digit does not match with corresponding digit in "seen" list,
                result = false; // break the loop and return false
                break;
            }
            tempX = (int) Math.Floor((double)(tempX/10));
        }
        return result;
    }
}