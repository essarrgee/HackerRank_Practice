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

    // Complete the minimumAbsoluteDifference function below.
    static int minimumAbsoluteDifference(int[] arr) {
		
		Array.Sort(arr);
		int minDifference = int.MaxValue;

		for (int i=1; i<arr.Length; i++) {
			int currentDifference1 = arr[i]-arr[i-1];
			int currentDifference2 = arr[i-1]-arr[i];
			if (currentDifference1 < minDifference && currentDifference1 >= 0) {
				minDifference = currentDifference1;
				if (minDifference == 0) {
					return 0;
				}
			}
			if (currentDifference2 < minDifference && currentDifference2 >= 0) {
				minDifference = currentDifference2;
				if (minDifference == 0) {
					return 0;
				}
			}
		}

		return minDifference;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = minimumAbsoluteDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
