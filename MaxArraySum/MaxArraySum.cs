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

    // Complete the maxSubsetSum function below.
    static int maxSubsetSum(int[] arr) {
        
        //create new array to store maximums
        //use previous maximums to determine current maximum for each iteration
        int[] maxArr = new int[arr.Length];
        //int maxSum = int.MinValue;
        
		maxArr[0] = Math.Max(0,arr[0]);
		maxArr[1] = Math.Max(arr[0],arr[1]);
		
        for (int i=2; i<arr.Length; i++) {
			maxArr[i] = Math.Max(maxArr[i-2]+arr[i], maxArr[i-1]);
			//maxSum = Math.Max(maxArr[i], maxSum);
        }
        
        return maxArr[arr.Length-1];//maxSum;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = maxSubsetSum(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
