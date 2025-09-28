using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        bool isUpperTen = num_list.Length > 10;
        int result = isUpperTen ? 0 : 1;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            result = isUpperTen ? result + num_list[i] : result * num_list[i];
        }
        return result;
    }
}