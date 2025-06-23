using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text;



    public class Solution
    {
        public int solution(int n)
        {
            int answer = 1;
            int beforeAnswer = 0;
            for (int i = 2; i <= n; i++)
            {
                int temp = answer;
                answer += beforeAnswer;
                answer %= 1234567;
                beforeAnswer = temp;
            }
            return (int)(answer % 1234567);
        }
    }