using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] array) => array.Select((x, i) => new int[]{x, i}).OrderBy(x => x[0]).Last();
}