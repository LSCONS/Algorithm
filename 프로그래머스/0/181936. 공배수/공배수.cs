using System;

public class Solution 
{
    public int solution(int number, int n, int m) 
    {
        int answer = 0;
        
        bool isSuccess = number % n == 0 && number % m == 0;
        
        answer = isSuccess ? 1 : 0;
        
        return answer;
    }
}