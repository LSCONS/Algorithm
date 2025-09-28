using System;

public class Solution 
{
    public int solution(int[,] board, int k) 
    {
        int heightLength = board.GetLength(0);
        int widthLength = board.GetLength(1);
        
        int result = 0;
        
        for(int i = 0; i < heightLength; i++)
        {
            for(int j = 0; j < widthLength; j++)
            {
                if(i + j > k)continue;
                result += board[i,j];
            }
        }
        return result;
    }
}