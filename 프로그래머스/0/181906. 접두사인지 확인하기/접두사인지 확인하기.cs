using System;

        public class Solution
        {
            public int solution(string my_string, string is_prefix)
            {
                if (is_prefix.Length > my_string.Length) return 0;
                if (is_prefix.Length == 0) return 0;

                for(int i = 0; i < is_prefix.Length; i++)
                {
                    if (my_string[i] != is_prefix[i]) return 0;
                }
                return 1;
            }
        }