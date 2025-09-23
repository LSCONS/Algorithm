using System;

public class Solution 
{
    public int solution(int[] num_list, int n) 
    {
        foreach(int temp in num_list)
        {
            if(temp == n) return 1;
        }
        return 0;
    }
}