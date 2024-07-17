/*
1. 아이디어
- switch case 사용
- Queue 메서드 사용

2. 시간복잡도
- O(N)

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
        Queue<int> queue = new Queue<int>();
        StringBuilder sb = new StringBuilder();
        
        for(int i=0; i<num; i++) {
            sb.Clear();
            string[] input = Console.ReadLine().Split();
            
            switch(input[0]) {
                case "push" :
                    queue.Enqueue(int.Parse(input[1]));
                    break;
                case "pop" :
                    if (queue.Count == 0) {
                        sb.Append(-1);
                    }else {
                        sb.Append(queue.Dequeue());
                    }
                    break;
                case "size" :
                    sb.Append(queue.Count);
                    break;
                case "empty" : 
                    if (queue.Count == 0) {
                        sb.Append(1);
                    }else {
                        sb.Append(0);
                    }
                    break;
                case "front" :
                    if (queue.Count == 0) {
                        sb.Append(-1);
                    }else {
                        int[] elements = queue.ToArray();
                        sb.Append(elements[0]);
                    }
                    break;
                case "back" :
                    if (queue.Count == 0) {
                        sb.Append(-1);
                    }else {
                        int[] elements = queue.ToArray();
                        sb.Append(elements[elements.Count()-1]);
                    }
                    break;
            }
            
            if (!input[0].Contains("push")) {
                Console.WriteLine(sb.ToString());
            }
        }
    }
}