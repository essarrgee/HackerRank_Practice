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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {

        double swaps = 0;
        bool chaotic = false;

        for (int i=0; i<q.Length; i++) {
            
            int value = q[i] - 1;

            if (value - i <= 2) {
                for (int o=Math.Max(0,value-2); o<i; o++) {
                    if (q[o] > q[i]) {
                        swaps++;
                    }
                }
            }
            else {
                chaotic = true;
                break;
            }

        }

        if (chaotic) {
            Console.WriteLine("Too chaotic");
        }
        else {
            Console.WriteLine(swaps);
        }
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
