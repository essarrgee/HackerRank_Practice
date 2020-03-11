class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastCharIndex = new Dictionary<char, int>();
        int currentLength = 0;
        int longestLength = 0;
        for (int i=0; i<s.Length; i++) {
            if (lastCharIndex.ContainsKey(s[i])) {
                if (currentLength > longestLength) {
                    longestLength = currentLength;
                }
                i = lastCharIndex[s[i]]+1;
                currentLength = 0;
                lastCharIndex.Clear();
            }
            lastCharIndex.Add(s[i], i);
            currentLength++;
        }
        if (currentLength > longestLength) {
            longestLength = currentLength;
        }
        return longestLength;
    }
};