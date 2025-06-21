using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text;

    public class Solution
    {
        public string solution(string s)
        {
            StringBuilder sb = new StringBuilder();
            bool isEmpty = true;
            for(int i = 0; i < s.Length; i++)
            {
                if (isEmpty && s[i] != ' ')
                {
                    sb.Append(char.ToUpper(s[i]));
                    isEmpty = false;
                }
                else
                {
                    sb.Append(char.ToLower(s[i]));
                    if (s[i] == ' ') isEmpty = true;
                }
            }
            return sb.ToString();
        }
    }