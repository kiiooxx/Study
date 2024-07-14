using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);

        Console.WriteLine((a+b)%c);
        Console.WriteLine(((a%c)+(b%c))%c);
        Console.WriteLine((a*b)%c);
        Console.WriteLine(((a%c)*(b%c))%c);
    }
}