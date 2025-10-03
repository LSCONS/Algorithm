using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int[] indices) 
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(my_string);
        for(int i = 0; i < indices.Length; i++)
        {
            sb[indices[i]] = '_';
        }
        sb.Replace("_", "");
        return sb.ToString();
    }
}