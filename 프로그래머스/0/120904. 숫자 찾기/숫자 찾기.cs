using System;

public class Solution 
{
    public int solution(int num, int k) 
    {
        int index = num.ToString().IndexOf(k.ToString());
        return index == -1 ? -1 : index + 1;
    }
}