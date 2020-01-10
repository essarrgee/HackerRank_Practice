using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the isValid function below.
    static string isValid(string s) {
        
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        Dictionary<int, int> amountCount = new Dictionary<int, int>();

        for (int i=0; i<s.Length; i++) {
            if (charCount.ContainsKey(s[i])) {
                charCount[s[i]]++;
            }
            else {
                charCount.Add(s[i], 1);
            }
        }

        foreach (KeyValuePair<char, int> x in charCount) {
            if (amountCount.ContainsKey(x.Value)) {
                amountCount[x.Value]++;
            }
            else {
                amountCount.Add(x.Value, 1);
            }
        }

        if (amountCount.Count == 2) {
            int largeAmount = 0;
            int toBeReducedAmount = 0;
            foreach (KeyValuePair<int, int> x in amountCount) {
                Console.WriteLine(x.Key + " " + x.Value);
                if (x.Value == 1) {
                    toBeReducedAmount = x.Key;
                }
                else {
                    largeAmount = x.Key;
                }
            }
            if ((largeAmount != 0 && toBeReducedAmount != 0 && ((toBeReducedAmount-largeAmount) == 1) || toBeReducedAmount-1==0)) {
                return "YES";
            }
        }
        else if (amountCount.Count == 1) {
            return "YES";
        }

        return "NO";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
