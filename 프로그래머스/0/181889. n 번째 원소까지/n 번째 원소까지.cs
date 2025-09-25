using System;

public class Solution 
{
    public int[] solution(int[] num_list, int n) 
    {
        int[] answer = new int[n];
        
        for(int i = 0; i < n; i++)
        {
            answer[i] = num_list[i];
        }
        //반복문 0부터 n까지 돌리고 answer에 대입 후 리턴
        
        return answer;
    }
}