using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        StringBuilder sb = new StringBuilder();
        
        for(int i=0; i<num; i++) {
            sb.Clear();
            string[] input = Console.ReadLine().Split();
            
            switch(input[0]) {
                case "push" :
                    stack.Push(int.Parse(input[1]));
                    break;
                case "pop" :
                    if (stack.Count == 0) {
                        sb.Append(-1);
                    }else {
                        sb.Append(stack.Pop());
                    }
                    break;
                case "size" :
                    sb.Append(stack.Count);
                    break;
                case "empty" : 
                    if (stack.Count == 0) {
                        sb.Append(1);
                    }else {
                        sb.Append(0);
                    }
                    break;
                case "top" :
                    if (stack.Count == 0) {
                        sb.Append(-1);
                    }else {
                        sb.Append(stack.Peek());
                    }
                    break;
            }
            
            if (!input[0].Contains("push")) {
                Console.WriteLine(sb.ToString());
            }
        }
    }
}