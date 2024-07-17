/*
1. 아이디어
- 공백으로 구분해서 문자열 자르기
- linq Reverse() 사용

2. 시간복잡도
- O(n2)

3. 자료구조
- 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        
        for(int i=0; i<num; i++) {
            string[] input = Console.ReadLine().Split();
            List<string> list = new List<string>();
            
            for(int j=0; j<input.Count(); j++) {
                list.Add(new string(input[j].Reverse().ToArray()));
            }
            
            Console.WriteLine(String.Join(" ", list));
        }
    }
}