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

    static Dictionary<int, List<int>> addValueToMap(Dictionary<int, List<int>> map3, int amount, int value) {
        if (map3.ContainsKey(amount)) {
            map3[amount].Add(value);
        } else {
            map3.Add(amount, new List<int>(){value});
        }
        return map3;
    }

    static Dictionary<int, List<int>> removeValueFromMap(Dictionary<int, List<int>> map3, int amount, int value) {
        if (map3.ContainsKey(amount)) {
            map3[amount].Remove(value);
        }
        return map3;
    }

    // Complete the freqQuery function below.
    static List<int> freqQuery(List<List<int>> queries) {

        //create dictionary storing all added query values as keys and # of times they appear as values
            //because order doesn't matter?
            //1- add one to respective counter
            //2- remove one from respective counter if > 0
            //3- check other dictionary created below for return value
        //create another dictionary storing # of times values appear as key
            //and those values themselves in an array as the values
        Dictionary<int, int> map12 = new Dictionary<int, int>();
        Dictionary<int, List<int>> map3 = new Dictionary<int, List<int>>();
        List<int> resultList = new List<int>();

        for (int i=0; i<queries.Count; i++) {
            if (queries[i][0] == 1) { //insert
                if (map12.ContainsKey(queries[i][1])) {
                    map3 = removeValueFromMap(map3, map12[queries[i][1]], queries[i][1]);
                    map12[queries[i][1]]++;
                } else {
                    map12.Add(queries[i][1], 1);
                }
                map3 = addValueToMap(map3, map12[queries[i][1]], queries[i][1]);
            }
            else if (queries[i][0] == 2) { //remove
                if (map12.ContainsKey(queries[i][1]) && map12[queries[i][1]] > 0) {
                    map3 = removeValueFromMap(map3, map12[queries[i][1]], queries[i][1]);
                    map12[queries[i][1]]--;
                    map3 = addValueToMap(map3, map12[queries[i][1]], queries[i][1]);
                }
            }
            else if (queries[i][0] == 3) { //check if appear EXACTLY z times
                if (map3.ContainsKey(queries[i][1]) && map3[queries[i][1]].Count > 0) {
                    resultList.Add(1);
                } else {
                    resultList.Add(0);
                }
            }
        }

        return resultList;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++) {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> ans = freqQuery(queries);

        textWriter.WriteLine(String.Join("\n", ans));

        textWriter.Flush();
        textWriter.Close();
    }
}
