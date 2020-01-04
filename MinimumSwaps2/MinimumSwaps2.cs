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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) {

        int swapCount = 0;
        Dictionary<int, int> position = new Dictionary<int, int>();
        
        for (int i=0; i<arr.Length; i++) {
            position.Add(arr[i], i);
        }
        
        for (int i=0; i<arr.Length; i++) {
            if (arr[i] != i+1) {
                
                int temp = arr[i];
                int tempPosition = position[i+1];

                arr[tempPosition] = temp;
                arr[i] = i+1;

                position[i+1] = i;
                position[temp] = tempPosition;

                swapCount++;
            }
        }

        for (int i=0; i<arr.Length; i++) {
            Console.WriteLine(arr[i]);
        }

        return swapCount;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
