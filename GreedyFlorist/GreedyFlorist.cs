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

    // Complete the getMinimumCost function below.
    static int getMinimumCost(int k, int[] c) {

        //take turns for each customer in list
        //sort list of prices
        int[] customers = new int[k];
        int totalPrice = 0;
        int priceIncrease = 0;
        int currentIndex = 0;
        Array.Sort(c);

        //two pointers:
            //one wrap around list of customers
            //one traverses price list backwards
        for (int i=c.Length-1; i>=0; i--) {
            int cost = c[i] * (1+priceIncrease);
            Console.WriteLine(currentIndex + " " + cost);
            customers[currentIndex] += cost;
            totalPrice += cost;
            currentIndex++;
            if (currentIndex >= k) {
                currentIndex = 0;
            }
            if (i != c.Length-1 && currentIndex == 0) {
                priceIncrease++;
            }
        }

        return totalPrice;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int minimumCost = getMinimumCost(k, c);

        textWriter.WriteLine(minimumCost);

        textWriter.Flush();
        textWriter.Close();
    }
}
