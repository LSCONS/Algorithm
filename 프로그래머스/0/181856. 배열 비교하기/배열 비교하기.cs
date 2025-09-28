using System;

public class Solution 
{
    public int solution(int[] arr1, int[] arr2) 
    {
        if(arr1.Length != arr2.Length)
        {
            return arr1.Length > arr2.Length ? 1 : -1;
        }
        
        
        int sumArr1 = 0;
        int sumArr2 = 0;
        for(int i  = 0; i < arr1.Length; i++)
        {
            sumArr1 += arr1[i];
            sumArr2 += arr2[i];
        }
        
        if(sumArr1 == sumArr2) return 0;
        return sumArr1 > sumArr2 ? 1 : -1;
    }
}