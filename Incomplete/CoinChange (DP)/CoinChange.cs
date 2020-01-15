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

    // Complete the ways function below.
    static int ways(int n, int[] coins) {
		
		//n = total amount
		//iterate through each number individually
			//if coins[i] is a multiple of n and < n
				//use 'n/coins[i]' and 
				//print coins[i] that many times
		//get sum of each number with every other number(s)
			//use dp to store their values for later use
			//test if sums are multiples of n and < n
				//if true, take mult = 10/sum
					//print each coin by mult times
				//ex: n = 10
				//coins: 2, 3
				//coinsum = 2+3 = 5
				// mult = n/coinsum = 2
				// so print coins[i] mult times

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] coins = Array.ConvertAll(Console.ReadLine().Split(' '), coinsTemp => Convert.ToInt32(coinsTemp))
        ;
        int res = ways(n, coins);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
