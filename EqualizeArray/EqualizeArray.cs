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

    // Complete the equalizeArray function below.
    static int equalizeArray(int[] arr) {
		
		int deletions = 0;
		
		int bestKey = 0;
		int mostAmount = 0;
		
		Dictionary<int, int> amountList = new Dictionary<int, int>();
		
		for (int i=0; i<arr.Length; i++) {
			if (amountList.ContainsKey(arr[i])) {
				amountList[arr[i]]++;
			}
			else {
				amountList.Add(arr[i], 1);
			}
			if (amountList[arr[i]] > mostAmount) {
				mostAmount = amountList[arr[i]];
				bestKey = arr[i];
			}
		}
		
		foreach (KeyValuePair<int, int> i in amountList) {
			if (i.Key != bestKey) {
				deletions += i.Value;
			}
		}
		
		return deletions;
		
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
