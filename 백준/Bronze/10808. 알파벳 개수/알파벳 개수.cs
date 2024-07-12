using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public static void Main(string[] args)
    {
        string arr = Console.ReadLine();
        List<int> list = new List<int>();
        int asciiNum=97;    //아스키코드 a
            
        for(int i=0; i<26; i++) {
            int count = 0;
            
            for(int j=0; j<arr.Count(); j++) {
                if(arr[j] == (char)asciiNum) {
                    count++;
                }
            }
            
            list.Add(count);
            asciiNum++;
        }
        
        Console.Write(String.Join(" ", list));
    }
}