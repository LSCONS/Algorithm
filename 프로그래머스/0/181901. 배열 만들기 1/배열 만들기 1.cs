using System;


        public class Solution
        {
            public int[] solution(int n, int k)
            {
                int temp = n / k;
                int[] result = new int[temp];

                for (int i = 0; i < temp; i++)
                {
                    result[i] = (i + 1) * k;
                }

                return result;
            }
        }