using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr, int[] delete_list) 
    {
        int[] answer = new int[] {};
        HashSet<int> hash = new HashSet<int>(arr);
        foreach(int delete in delete_list)
        {
            hash.Remove(delete);
        }
        return hash.ToArray();
    }
}