using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        int evenCount = num_list.Count(x => x % 2 == 0);
        int oddCount = num_list.Length - evenCount;
        return new int[]{evenCount, oddCount};
    }
}