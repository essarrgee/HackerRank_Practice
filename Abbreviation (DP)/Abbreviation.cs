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

    // Complete the abbreviation function below.
    static string abbreviation(string a, string b) {

        //INCORRECT: string a's order also matters

        //create dictionary for a
            //store each character and the amount of times they 
            //appear as key and value
        //iterate through string b
            //check if each character key and value match that of dictionary a
                //if not, return 'NO'
        //if passed everything, return 'YES'
        Dictionary<char, int> charA = new Dictionary<char, int>();
        string newA = a;

        for (int i=0; i<a.Length; i++) {
            if (charA.ContainsKey(a[i])) {
                charA[a[i]]++;
            } else {
                charA.Add(a[i], 1);
            }
        }

        for (int i=0; i<b.Length; i++) { //check if exist or has lower
            if (charA.ContainsKey(b[i]) && charA[b[i]] > 0) { 
                charA[b[i]]--;
            } else if (charA.ContainsKey(char.ToLower(b[i])) && charA[char.ToLower(b[i])] > 0) {
                charA[char.ToLower(b[i])]--;
            } else {
                return "NO";
            }
        }

        foreach (KeyValuePair<char, int> x in charA) {
            if (x.Value > 0 && char.IsUpper(x.Key)) {
                return "NO";
            }
        }

        return "YES";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            string result = abbreviation(a, b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
