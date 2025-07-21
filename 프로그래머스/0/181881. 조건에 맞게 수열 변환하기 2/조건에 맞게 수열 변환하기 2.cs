using System;

    public class Solution
    {
        public int solution(int[] arr)
        {
            int answer = 0;
            bool isChange = true;

            while(isChange)
            {
                isChange = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 50)
                    {
                        if (arr[i] % 2 == 0) 
                        {
                            arr[i] /= 2;
                            isChange = true;
                        }
                        
                    }
                    else
                    {
                        if (arr[i] % 2 == 1) 
                        {
                            arr[i] = arr[i] * 2 + 1;
                            isChange = true;
                        } 
                    }
                }
                if(isChange)
                answer++;
            }

            return answer;
        }
    }