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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {

        int deletion = 0;
        Dictionary<char, int> aCount = new Dictionary<char, int>();
        Dictionary<char, int> bCount = new Dictionary<char, int>();

        for (int i=0; i<a.Length; i++) {
            if (!aCount.ContainsKey(a[i])) {
                aCount.Add(a[i], 1);
            }
            else {
                aCount[a[i]]++;
            }
        }
        for (int i=0; i<b.Length; i++) {
            if (!bCount.ContainsKey(b[i])) {
                bCount.Add(b[i], 1);
            }
            else {
                bCount[b[i]]++;
            }
        }

        for (int i=0; i<a.Length; i++) {
            if ((!bCount.ContainsKey(a[i]) && aCount[a[i]] > 0) || aCount[a[i]] > bCount[a[i]]) {
                aCount[a[i]]--;
                deletion++;
            }
        }
        for (int i=0; i<b.Length; i++) {
            if ((!aCount.ContainsKey(b[i]) && bCount[b[i]] > 0) || bCount[b[i]] > aCount[b[i]]) {
                bCount[b[i]]--;
                deletion++;
            }
        }

        return deletion;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
