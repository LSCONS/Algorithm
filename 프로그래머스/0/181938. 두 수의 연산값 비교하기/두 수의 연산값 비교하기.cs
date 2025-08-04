using System;

    public class Solution
    {
        public int solution(int a, int b)
        {
            int bCount = TempMethod(b);
            int resultA = a * bCount + b;
            int resultB = 2 * a * b;
            return (resultA >= resultB) ? resultA : resultB;
        }

        public int TempMethod(int value)
        {
            int result = 0;
            while(true)
            {
                if (value > 0)
                {
                    value = value / 10;
                    result++;
                }
                else break;
            }
            return ComputeCount(result);
        }


        public int ComputeCount(int count)
        {
            int result = 1;
            for(int i = 0; i < count; i++)
            {
                result *= 10;
            }
            return result;
        }
    }