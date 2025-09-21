using System;

public class Solution 
{
    public int[] solution(int[] num_list, int n) 
    {
        int length = (num_list.Length - 1) / n + 1;
        int[] answer = new int[length];
        
        for(int i = 0; i < length; i++)
        {
            answer[i] = num_list[i * n];
        }
        
        return answer;
    }
}