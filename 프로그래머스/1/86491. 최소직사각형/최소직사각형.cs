using System;

    public class Solution
    {
        public int solution(int[,] sizes)
        {
            int leftMax = 0;
            int rightMax = 0;
            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                if (sizes[i,0] < sizes[i, 1])
                {
                    int temp = sizes[i,0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = temp;
                }

                if(sizes[i, 0] > leftMax) leftMax = sizes[i, 0];

                if (sizes[i, 1] > rightMax) rightMax = sizes[i, 1];
            }
            return leftMax * rightMax;
        }
    }