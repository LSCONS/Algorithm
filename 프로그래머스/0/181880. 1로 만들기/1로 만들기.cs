using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        for(int i = 0; i< num_list.Length; i++)
        {
            answer += (int)Math.Floor(Math.Log(num_list[i], 2));
        }
        return answer;
    }
}