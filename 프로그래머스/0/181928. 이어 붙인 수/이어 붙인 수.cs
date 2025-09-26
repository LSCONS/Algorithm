using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int evenNum = 0;
        int oddNum = 0;
        for(int i = 0; i < num_list.Length; i++)
        {
            if(num_list[i] % 2 == 0)
            {
                evenNum = evenNum * 10 + num_list[i];
            }
            else
            {
                oddNum = oddNum * 10 + num_list[i];
            }
        }
        //0부터 배열 수까지 반복문. 원소가 짝수면 even에 10을 곱한후 더함. 홀수면 odd에 10을 곱한후 더함
        return evenNum + oddNum;
    }
}