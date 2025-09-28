using System;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        if(myString.ToLower().Contains(pat.ToLower()))return 1;
        return 0;
    }
}