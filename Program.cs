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

class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int chocolate = 0;
        int sum = 0;
        for (int i = 0; i < s.Count; i++)
        {
            sum += s[i];
            if (i >= m)
            {
                sum -= s[i - m]; // odejmujemy aby segment utrzymać o długości m
            }
            if (i >= m - 1 && sum == d)
            {
                chocolate++;
            }
        }
        return chocolate;
    }
    public static int birthday1(List<int> s, int d, int m)
    {
        int chocolate = 0;
        for (int i = 0; i <= s.Count - m; i++)
        {
            if (s.Skip(i).Take(m).Sum() == d) chocolate++;
        }
        return chocolate;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

        Console.WriteLine(result);

        int result1 = Result.birthday1(s, d, m);

        Console.WriteLine(result1);

    }
}
