using System;

public class Solution 
{
    public int[] solution(int[] num_list, int n) 
    {
        int newLength = num_list.Length - n + 1;
        int index = 0;
        if(newLength < 0) return null;
        int[] answer = new int[newLength];
        for(int i = n - 1; i < num_list.Length; i++)
        {
            answer[index++] = num_list[i];
        }
        return answer;
    }
}