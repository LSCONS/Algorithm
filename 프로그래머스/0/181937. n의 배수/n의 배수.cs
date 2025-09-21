using System;

public class Solution 
{
    public int solution(int num, int n) 
    {
        int answer = 0;
        
        bool isSuccess = num % n == 0;
        
        answer = isSuccess ? 1 : 0;
        
        return answer;
    }
}