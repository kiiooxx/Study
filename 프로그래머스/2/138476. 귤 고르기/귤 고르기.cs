using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;

        var distinct = tangerine.GroupBy(g => g).Select(s => s.Count());    //tangerine group by해서 숫자 count
        var orderList = distinct.OrderByDescending(x => x).ToList();     //desc 정렬

        int result = k;
        while (result > 0)
        {
            result -= orderList[answer];
            answer++;
        }

        return answer;
    }
}