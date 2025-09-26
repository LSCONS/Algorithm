using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        int multipleAll = 1;
        int addSquared = 0;
        for(int i = 0; i < num_list.Length; i++)
        {
            multipleAll *= num_list[i];
            addSquared += num_list[i];
        }
        addSquared *= addSquared;
        answer = addSquared > multipleAll ? 1 : 0;
        return answer;
    }
}