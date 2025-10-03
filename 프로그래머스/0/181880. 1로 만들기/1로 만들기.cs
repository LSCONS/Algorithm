using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        foreach(int i in num_list)
            answer += (int)Math.Floor(Math.Log(i, 2));
        return answer;
    }
}