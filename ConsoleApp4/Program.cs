using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{
    public static IEnumerable<string> Split(this string str, int n)
    {
        if (String.IsNullOrEmpty(str) || n < 1)
        {
            throw new ArgumentException();
        }

        return Enumerable.Range(0, str.Length / n)
                        .Select(i => str.Substring(i * n, n));
    }
}

public class Example
{
    public static void Main()
    {
        string str = "123456789394348549560954675";
        int size = 5;
        Console.WriteLine(str);

        IEnumerable<string> s = str.Split(size);
        Console.WriteLine(String.Join(Environment.NewLine, s));
    }
}


