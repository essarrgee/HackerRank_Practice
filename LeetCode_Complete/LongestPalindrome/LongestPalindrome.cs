public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char, int> palette = new Dictionary<char, int>();
        Dictionary<int, List<char>> paletteActual = new Dictionary<int, List<char>>();
        string newS = "";
        string remainder = "";
        for (int i=0; i<s.Length; i++) {
            if (!palette.ContainsKey(s[i])) {
                palette.Add(s[i], 1);
            }
            else {
                palette[s[i]]++;
            }
        }
        foreach (KeyValuePair<char, int> kvp in palette) {
            if (!paletteActual.ContainsKey(kvp.Value)) {
                paletteActual.Add(kvp.Value, new List<char>());
                
            }
            if (kvp.Value > 1 || (kvp.Value == 1 && paletteActual[kvp.Value].Count < 1)) {
                paletteActual[kvp.Value].Add(kvp.Key);
            }
        }
        for (int i=1; i<=s.Length; i++) {
            if (paletteActual.ContainsKey(i)) {
                int amount = i;
                Console.WriteLine(amount);
                for (int o=0; o<paletteActual[i].Count; o++) {
                    int amountToInsert = amount/2;
                    bool insertAtEnd = true;
                    if (amount%2 != 0) {
                        amount--;
                        if (remainder == "") {
                            remainder = "" + paletteActual[i][o];
                        }
                    }
                    if (newS.Length <= 0) {
                        amountToInsert = amount;
                        insertAtEnd = false;
                    }
                    string toInsert = new string(paletteActual[i][o], amountToInsert);
                    newS = newS.Insert(0, toInsert);
                    if (insertAtEnd) {
                        newS = newS.Insert(newS.Length, toInsert);
                    }
                }
                
            }
        }
        if (remainder != "") {
            newS = newS.Insert((newS.Length)/2, remainder);
        }
        Console.WriteLine(newS);
        return newS.Length;
    }
}