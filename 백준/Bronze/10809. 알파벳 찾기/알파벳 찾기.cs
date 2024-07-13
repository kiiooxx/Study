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
            int num = -1;

            for(int j=0; j<arr.Count(); j++) {
                if(num == -1 && arr[j] == (char)asciiNum) {    //num = -1 조건 이유 : 처음 등장하는 위치여야 하니까..
                    num = j;
                }
            }

            list.Add(num);
            asciiNum++;
        }

        Console.Write(String.Join(" ", list));
    }
}