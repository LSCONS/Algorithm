using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    Stack<int> stack = new Stack<int>();
    public int[] solution(int[] arr, bool[] flag) 
    {
        for(int i = 0; i < flag.Length; i++)
        {
            if(flag[i])
            {
                for(int j = 0; j < arr[i] * 2; j++)
                {
                    stack.Push(arr[i]);
                }
            }
            else
            {
                for(int j = 0; j < arr[i]; j++)
                {
                    stack.Pop();
                }
            }
        }
        
        return stack.Reverse().ToArray();
    }
}