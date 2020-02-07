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

    // Complete the stepPerms function below.
    static int stepPerms(int n) {

        //different fibonacci
        //number of ways for each step = steps(i-1)+steps(i-2)+steps(i-3)
        //except where i=0, i=1, i=2, where steps = 1, 2, 4 respectively
        int[] waysArr = new int[n];
        waysArr[0] = 1;
        if (n >= 2) {
            waysArr[1] = 2;
        }
        if (n >= 3) {
            waysArr[2] = 4;
        }
        for (int i=3; i<n; i++) {
            waysArr[i] = waysArr[i-1]+waysArr[i-2]+waysArr[i-3];
        }
        return waysArr[n-1];
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int s = Convert.ToInt32(Console.ReadLine());

        for (int sItr = 0; sItr < s; sItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int res = stepPerms(n);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
