using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] sides) 
        => sides.Sum() - (sides.Max() - sides.Min() + 1);
}