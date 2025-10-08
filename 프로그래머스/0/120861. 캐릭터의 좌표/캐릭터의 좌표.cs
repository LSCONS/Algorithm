using System;

public class Solution 
{
    public int[] solution(string[] keyinput, int[] board) 
    {
        int maxWidth = board[0] / 2;
        int maxHeight = board[1] / 2;
        
        int nowWidth = 0;
        int nowHeight = 0;
        
        for(int i = 0; i < keyinput.Length; i++)
        {
            switch(keyinput[i])
            {
                case "left": if(nowWidth > -maxWidth) nowWidth--; break;
                case "right": if(nowWidth < maxWidth) nowWidth++; break;
                case "up": if(nowHeight < maxHeight) nowHeight++; break;
                case "down": if(nowHeight > -maxHeight) nowHeight--; break;
            }
        }
        return new int[]{nowWidth, nowHeight};
    }
}