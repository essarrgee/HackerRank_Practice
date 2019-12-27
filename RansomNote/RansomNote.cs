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

    // Complete the checkMagazine function below.
    static string checkMagazine(string[] magazine, string[] note) {
       
        Dictionary<string, int> wordBank = new Dictionary<string, int>();
    
        for (int i=0; i<magazine.Length; i++) {
            if (!wordBank.ContainsKey(magazine[i])) {
                wordBank.Add(magazine[i], 1);
            }
			else {
				wordBank[magazine[i]]++;
			}
        }

        for (int i=0; i<note.Length; i++) {
            if (!wordBank.ContainsKey(note[i]) || wordBank[note[i]] <= 0) {
                return "No";
            }
			else {
				wordBank[note[i]]--;
			}
        }
        
        return "Yes";
        
    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        Console.WriteLine(checkMagazine(magazine, note));
    }
}
