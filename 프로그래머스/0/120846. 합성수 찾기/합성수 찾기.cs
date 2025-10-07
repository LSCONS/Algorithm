using System;

public class Solution 
{
    public int solution(int n) 
    {
        return n - CountPrimes(n);
    }
    
    public int CountPrimes(int n)
    {
        int count = 1; // 소수에 1 포함
        bool[] isPrimes = new bool[n + 1];
        
        for(int i = 2; i <= n; i++)
        {
            isPrimes[i] = true;
        }
        
        for(int i = 2; i * i <= n; i++)
        {
            if(isPrimes[i])
            {
                for(int j = i * i; j <= n; j += i)
                {
                    isPrimes[j] = false;
                }
            }
        }
        
        for(int i = 2; i <= n; i++)
        {
            if(isPrimes[i]) count++;
        }
        
        return count;
    }
}