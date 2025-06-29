using System;

    public class Solution
    {
        public bool solution(string s)
        {
            int left = 0;
            int right = 0;
            foreach(char c in s)
            {
                if (c == '(') left++;
                else right++;

                if (left < right) return false;
            }
            if (left != right) return false;
            return true;
        }
    }