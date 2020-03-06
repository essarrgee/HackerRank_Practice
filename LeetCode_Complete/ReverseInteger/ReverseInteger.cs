public class Solution {
    
    public int Reverse(int x) {
        if (x >= Int32.MinValue && x <= Int32.MaxValue) {
            // Convert x to positive if x is originally negative
            int negative = 1;
            // Start with type LONG to avoid rounding errors ****IMPORTANT****
            long xNew = 0;
            if (x < 0) {
                negative = -1;
            }
            x = x*negative;
            // Convert x to string, iterate through string while 
                // adding each value to a new int by  multiplying them with 10^index,
                // which flips the value
            string xToString = x.ToString();
            // Check for negative sign
            if (xToString[0] == '-') {
                xToString = xToString.Remove(0,1);
            }
            for (int i=0; i<xToString.Length; i++) {
                // Check toAdd is within 32-bit signed int range
                
                long toAdd = (long)Int32.Parse("" + xToString[i]) * (long)Math.Pow(10, i);
                if (toAdd < Int32.MinValue || toAdd > Int32.MaxValue) {
                    return 0;
                }
                else {
                    xNew += toAdd;
                }
            }

            // Convert new x back to negative if originally negative
            xNew = xNew * negative;

            // Check x is within 32-bit signed int range
            if (xNew >= Int32.MinValue && xNew <= Int32.MaxValue) {
                return (int)xNew;
            }
        }
        return 0;
    }
}