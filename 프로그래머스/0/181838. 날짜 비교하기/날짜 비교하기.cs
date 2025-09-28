using System;

public class Solution 
{
    public int solution(int[] date1, int[] date2) 
    {
        for(int i = 0; i < date1.Length; i++)
        {
            Console.Write($"date1 = {date1[i]} ?? ");
            Console.WriteLine($"date2 = {date2[i]}");
            if(date1[i] == date2[i]) continue;
            return date1[i] < date2[i] ? 1 : 0;
        }
        return 0;
    }
}