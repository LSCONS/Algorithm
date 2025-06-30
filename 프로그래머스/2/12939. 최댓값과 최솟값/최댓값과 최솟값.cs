    using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;


    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            string[] arr = s.Split(' ');
            int[] intArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (int.TryParse(arr[i], out int num))
                {
                    intArr[i] = num;
                }
            }

            int min = intArr.Min();
            int max = intArr.Max();

            answer = $"{min} {max}";

            return answer;
        }
    }