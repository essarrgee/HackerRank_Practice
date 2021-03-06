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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
		
		int numberOfPairs = 0;
        Dictionary<int, int> sockInventory = new Dictionary<int, int>();

        for (int i=0; i<n; i++) {
            if (sockInventory.ContainsKey(ar[i])) {
                sockInventory[ar[i]]++;
            }
			else {
				sockInventory.Add(ar[i], 1);
			}
        }
		
		foreach(KeyValuePair<int, int> i in sockInventory) {
			numberOfPairs += (i.Value-(i.Value%2))/2;
		}
		
		return numberOfPairs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
